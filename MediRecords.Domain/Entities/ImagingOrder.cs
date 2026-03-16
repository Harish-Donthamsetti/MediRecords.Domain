using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediRecords.Domain.Entities;

[Table("ImagingOrder")]
public class ImagingOrder
{
    [Key]
    public int ImagingOrderId { get; set; }

    [Required]
    public int EncounterId { get; set; }

    [Column(TypeName = "VARCHAR(100)")]
    public string StudyType { get; set; }

    [Column(TypeName = "VARCHAR(MAX)")]
    public string Notes { get; set; }

    public DateTime OrderedDate { get; set; }

    public bool Status { get; set; }
}
