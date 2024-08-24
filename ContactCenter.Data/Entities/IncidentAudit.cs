using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ContactCenter.Data
{
    public class IncidentAudit
    {
        public int Id { get; set; }
        public int IncidentId { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public DateTime StatusChangeTime { get; set; }
        public string UserId { get; set; }
        public string NameOfUpdater { get; set; }
        public string SurnameOfUpdater { get; set; }
        public string ShortSummary { get; set; }
        public string DetailedDescription { get; set; }

        [JsonIgnore]  // Prevents cyclical reference during serialization
        public Incident Incident { get; set; }
        public IncidentStatus Status { get; set; }
    }
}
