using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediRecords.Domain.Entities;

[Table("LabOrder")]
public class LabOrder
{
    [Key]
    public int LabOrderId { get; set; }

    [Required]
    public int EncounterId { get; set; }

    [Required]
    public int OrderedBy { get; set; }

    [Required]
    [Column(TypeName = "VARCHAR(MAX)")]
    public string TestJson { get; set; }

    public DateTime OrderDate { get; set; }
    
    public bool Status { get; set; }
}
