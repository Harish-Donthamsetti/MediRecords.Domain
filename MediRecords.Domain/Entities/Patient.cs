using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediRecords.Domain.Entities;

[Table("Patient")]
public class Patient
{
    [Key]
    public int PatientId { get; set; }

    [Required]
    [MaxLength(50)]
    public string MRN { get; set; }

    [Required]
    [MaxLength(255)]
    public string Name { get; set; }

    [Required]
    public DateTime DOB { get; set; }

    [MaxLength(20)]
    public string? Gender { get; set; }

    public string? AddressJSON { get; set; }

    [MaxLength(255)]
    public string? ContactInfo { get; set; }

    public int? PrimaryProviderId { get; set; }

    [MaxLength(20)]
    public string Status { get; set; } = "Active";
}
