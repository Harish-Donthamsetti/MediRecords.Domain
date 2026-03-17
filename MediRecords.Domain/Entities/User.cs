using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediRecords.Domain.Entities;

[Table("User")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int UserId { get; set; }

    [Required]
    [Column(TypeName = "VARCHAR(30)")]
    public string Name { get; set; }

    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [ForeignKey("RoleIdNavigation")]
    public int RoleId { get; set; }

    [Required]
    [Column(TypeName = "VARCHAR(100)")]
    public string Email { get; set; }

    [Column(TypeName = "VARCHAR(15)")]
    public string Phone { get; set; }

    [Column(TypeName = "VARCHAR(MAX)")]
    public string PasswordHash { get; set; }
    
    [Column(TypeName = "VARCHAR(MAX)")]
    public string PasswordSalt { get; set; }
    
    public bool Status { get; set; }

    /*-------------------------Foreign Key References--------------------------------*/
    public virtual UserRole? RoleIdNavigation { get; set; }
    public virtual ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
}
