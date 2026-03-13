using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediRecords.Domain.Entities
{
    [Table("Prescriptions")]
    public class Prescriptions
    {
        [Key]
        public int PrescriptionId { get; set; }
        
        public int EncounterId { get; set; }

        public int ProviderId { get; set; }
        
        public DateTime CreatedDate { get; set; }
        
        public bool Status { get; set; }
    }
}