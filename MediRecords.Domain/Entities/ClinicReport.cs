using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediRecords.Domain.Entities;

[Table("ClinicReport")]
public class ClinicReport
{
    [Key]
    public int ReportId { get; set; }

    [Required]
    [Column(TypeName = "VARCHAR(50)")]
    public string Scope { get; set; }  //(Provider/Period/ServiceType)

    [Required]
    [Column(TypeName = "VARCHAR(50)")]  //(VisitCount, LabsOrdered, RxIssued)
    public string Metrics { get; set; }

    [Required]
    [ForeignKey("GeneratedByNavigation")]
    public int GeneratedBy { get; set; }

    public DateTime GeneratedDate { get; set; }

    /*-------------------------Foreign Key References--------------------------------*/
    public virtual User? GeneratedByNavigation { get; set; }
}
