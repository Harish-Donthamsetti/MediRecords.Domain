using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediRecords.Models;

[Table("VitalSign")]
public class VitalSign
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int VitalId { get; set; }
    

    public int EncounterId { get; set; }


    [Required]
    [Column(TypeName="VARCHAR(50)")]
    public string Type { get; set; }


    [Required]
    [Column(TypeName="VARCHAR(50)")]
    public int Value { get; set; }


    [Required]
    [Column(TypeName="VARCHAR(20)")]
    public string Unit{ get; set; }
    
    
    public DateTime RecordedDate { get; set; }


    [Required]
    [Column(TypeName="VARCHAR(50)")]
    public string RecordedBy { get; set; }
}