using System;

namespace MediRecords.Domain.Entities;

public class ClinicalTemplate
{
    public int TemplateID { get; set; }
    public string Name { get; set; }
    public string TemplateType { get; set; }
    public string ContentJSON { get; set; }
    public bool Status { get; set; }
}
