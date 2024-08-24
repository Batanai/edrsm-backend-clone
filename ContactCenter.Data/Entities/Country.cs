using System;
using System.Collections.Generic;

namespace ContactCenter.Data
{
    public partial class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string DialingCode { get; set; }
    }
}
