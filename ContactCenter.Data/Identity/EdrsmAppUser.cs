using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCenter.Data.Identity
{
    public class EdrsmAppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DisplayName { get; set; }
        public string MunicipalityAccountNumber { get; set; }
        public string CellphoneNumber { get; set; }
        public int PreferredContactMethodId { get; set; }
        public int IdentificationTypeId { get; set; }
        public int CountryOfOriginId { get; set; }
        public string IdentificationNumber { get; set; }
        public bool AgreedToTerms { get; set; }
        public bool IsAdmin { get; set; }
        public string Ward { get; set; }
        public string ProfileImageUrl { get; set; }
        public string CloudinaryPublicId { get; set; }
    }
}
