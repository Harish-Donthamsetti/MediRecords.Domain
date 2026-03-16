using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediRecords.Domain.Entities
{
    [Table("MedicationList")]
    public class MedicationList
    {
        [Key]
        public int MedId { get; set; }

        [Required]
        public int PatientId { get; set; }
        
        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }

        [Required]
        [MaxLength(100)]
        public string DrugName { get; set; }

        [MaxLength(50)]
        public string Dose { get; set; }

        [MaxLength(50)]
        public string Frequency { get; set; }

        [MaxLength(50)]
        public string Route { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
        
        public bool IsActive { get; set; }
    }
}