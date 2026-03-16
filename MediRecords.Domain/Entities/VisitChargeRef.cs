using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MediRecords.Domain.Entities;

[Table("VisitChargeRef")]
public class VisitChargeRef
{
    [Key]
    public int ChargeId { get; set; }

    public int EncounterId { get; set; }

    public int CodeId { get; set; }

    [Column(TypeName = "DECIMAL(18,2)")]
    public decimal Amount { get; set; }

    public bool Status { get; set; }

    [ForeignKey("EncounterId")]
    public virtual Encounter Encounter { get; set; }

    [ForeignKey("CodeId")]
    public virtual ProcedureCode ProcedureCode { get; set; }
}