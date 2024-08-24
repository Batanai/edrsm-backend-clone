using System;
using System.Collections.Generic;

namespace ContactCenter.Data
{
    public class Incident
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public int StatusId { get; set; }
        public DateTime TimePosted { get; set; }
        public string LocationAddress { get; set; }
        public string LocationCoordinates { get; set; }
        public string ContactNumber { get; set; }
        public string UserId { get; set; }
        public int IncidentHeadingId { get; set; }
        public string HeadingName { get; set; }
        public int IncidentTypeId { get; set; }
        public string TypeName { get; set; }


        public IncidentStatus Status { get; set; }
        public IncidentHeading IncidentHeading { get; set; }
        public ICollection<IncidentAudit> IncidentAudits { get; set; }
    }
}
