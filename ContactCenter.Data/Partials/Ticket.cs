using ContactCenter.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCenter.Data
{
    partial class Ticket
    {
        [NotMapped]
        public TicketStatus Status
        {
            get => (TicketStatus)StatusId;
            set => StatusId = (int)value;
        }

        [NotMapped]
        public TicketType Type
        {
            get => (TicketType)TypeId;
            set => TypeId = (int)value;
        }
    }
}
