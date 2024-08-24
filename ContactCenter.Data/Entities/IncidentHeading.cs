using System;
using System.Collections.Generic;

namespace ContactCenter.Data
{
    public class IncidentHeading
    {
        public int Id { get; set; }
        public int IncidentTypeId { get; set; }
        public string HeadingName { get; set; }

        public IncidentType IncidentType { get; set; }
        public ICollection<Incident> Incidents { get; set; }
    }
}
