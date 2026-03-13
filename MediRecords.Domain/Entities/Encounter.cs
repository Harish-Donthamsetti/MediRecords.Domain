using System;

namespace MediRecords.Domain.Entities;

public class Encounter
{
    public int EncounterID { get; set; }
    public int PatientID { get; set; }
    public int ProviderID { get; set; }
    public DateTime Date { get; set; }
    public string VisitType { get; set; }
    public bool Status { get; set; }
}
