using System;
using System.Collections.Generic;

namespace ContactCenter.Data
{
    public class IncidentType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public ICollection<IncidentHeading> IncidentHeadings { get; set; }
    }
}
