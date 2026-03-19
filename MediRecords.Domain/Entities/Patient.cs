using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

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

    [ForeignKey("PrimaryProviderId")]
    public int? PrimaryProviderId { get; set; }

    [MaxLength(20)]
    public string Status { get; set; } = "Active";

    /*-------------------------Foreign Key References--------------------------------*/
    public virtual ICollection<Allergy> Allergy { get; set; } = new List<Allergy>();

    public virtual ICollection<MedicalHistory> MedicalHistory { get; set; } = new List<MedicalHistory>();

    public virtual ICollection<ProblemList> ProblemLists { get; set; } = new List<ProblemList>();

    public virtual ICollection<Immunization> Immunizations { get; set; } = new List<Immunization>();

    public virtual ICollection<CarePlan> CarePlans { get; set; } = new List<CarePlan>();

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual ICollection<Encounter> Encounters { get; set; } = new List<Encounter>();

    public virtual ICollection<MedicationList> MedicationLists { get; set; } = new List<MedicationList>();

    public virtual ICollection<Appointment> Appointment { get; set; } = new List<Appointment>();
}