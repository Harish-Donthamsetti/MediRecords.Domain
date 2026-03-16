using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediRecords.Domain.Entities
{
    [Table("PrescriptionItem")]
    public class PrescriptionItem
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        public int PrescriptionId { get; set; }

        [ForeignKey("PrescriptionId")]
        public virtual Prescriptions Prescription { get; set; }

        [Required]
        [MaxLength(100)]
        public string DrugName { get; set; }

        [MaxLength(50)]
        public string Dose { get; set; }

        [MaxLength(50)] 
        public string Frequency { get; set; }

        public int DurationDays { get; set; }
        
        public string Instructions { get; set; }
    }
}