using System;
using System.Collections.Generic;

namespace ContactCenter.Data
{
    public partial class Admin
    {
        public Admin()
        {
            Incidents = new HashSet<Incident>();
            Queries = new HashSet<Query>();
            RequestedPaymentPlans = new HashSet<RequestedPaymentPlan>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public string Username { get; set; }

        public virtual ICollection<Incident> Incidents { get; set; }
        public virtual ICollection<Query> Queries { get; set; }
        public virtual ICollection<RequestedPaymentPlan> RequestedPaymentPlans { get; set; }
    }
}
