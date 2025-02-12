﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ContactCenter.Lib.DataSync
{
    public class IContact
    {
        public string Id { get; set; }  
        public string FirstName { get; set; }    
        public string LastName { get; set; }    
        public string Email { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }
    }
}
