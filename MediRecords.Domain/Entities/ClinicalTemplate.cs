using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MediRecords.Domain.Entities;

[Table("ClinicalTemplate")]
public class ClinicalTemplate
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int TemplateId { get; set; }

    [Column( TypeName = "nvarchar(max)")]
    public string Name { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string TemplateType { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string ContentJSON { get; set; }

    public bool Status { get; set; }
}
