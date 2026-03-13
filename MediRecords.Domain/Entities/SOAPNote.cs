using System;

namespace MediRecords.Domain.Entities;

public class SOAPNote
{
    public int NoteID { get; set; }
    public int EncounterID { get; set; }
    public string Subjective { get; set; }
    public string Objective { get; set; }
    public string Assessment { get; set; }
    public string Plan { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool Status { get; set; }
}
