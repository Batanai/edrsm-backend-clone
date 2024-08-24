using System;
using System.Collections.Generic;

namespace ContactCenter.Data
{
    public class IncidentStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; }

        public ICollection<IncidentAudit> IncidentAudits { get; set; }
    }
}
