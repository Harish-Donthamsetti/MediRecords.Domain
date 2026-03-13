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
    public int VitalId { get; set; } // Primary Key ID for all Vital Signs.
    

    public int EncounterId { get; set; } // ID of the Encounter.


    [Required]
    [Column(TypeName="VARCHAR(50)")]
    public string Type { get; set; } // Type of Vitals recorded.


    [Required]
    [Column(TypeName="VARCHAR(50)")]
    public int Value { get; set; } // Value of the Vitals recorded.


    [Required]
    [Column(TypeName="VARCHAR(20)")]
    public string Unit{ get; set; } // Unit in which the Vitals are recorded.
    
    
    public DateTime RecordedDate { get; set; } // Date of the Vitals recorded.


    [Required]
    [Column(TypeName="VARCHAR(50)")]
    public string RecordedBy { get; set; } // Name of the User who recorded the Vitals.
}