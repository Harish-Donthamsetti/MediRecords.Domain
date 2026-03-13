using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediRecords.Domain.Entities;

[Table("Encounter")]
public class Encounter
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int EncounterId { get; set; }

    public int PatientId { get; set; }

   public int ProviderId { get; set; }

    public DateTime Date { get; set; }

    [Column(TypeName = "nvarchar(MAX)")]
    public string VisitType { get; set; }
    public bool Status { get; set; }
}
