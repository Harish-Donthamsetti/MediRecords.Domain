using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediRecords.Models;

[Table("NursingNote")]
public class NursingNote
{   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int NursingNoteId { get; set; }


    [Required]
    public int EncounterId { get; set; }


    [Column(TypeName ="VARCHAR(50)")]
    public string Notes { get; set; }


    [Required]
    [Column(TypeName ="VARCHAR(50)")]
    public string RecordedBy { get; set; }


    public DateTime RecordedDate { get; set; }
}