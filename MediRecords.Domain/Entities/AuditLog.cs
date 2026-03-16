using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediRecords.Domain.Entities;

[Table("AuditLog")]
public class AuditLog
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AuditId { get; set; }

    public int UserId { get; set; }

    [Column(TypeName = "VARCHAR(100)")]
    public string Action { get; set; }

    [Column(TypeName = "VARCHAR(255)")]
    public string Resource { get; set; }

    public DateTime TimeStamp { get; set; }
}
