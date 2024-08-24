using ContactCenter.Data;
using ContactCenter.Data.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace EDRSM.API.Extentions
{
    public static class IdentityServicesExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services,
            IConfiguration config)
        {
            services.AddDbContext<EdrsmIdentityDbContext>(opt =>
            {
                opt.UseNpgsql(config.GetConnectionString("DefaultConnection"));
            });

            services.AddIdentityCore<EdrsmAppUser>(opt =>
            {
                // add identity options here
                // opt.Password.
                opt.Password.RequireDigit = false;             // Do not require a digit
                opt.Password.RequireLowercase = false;         // Do not require a lowercase letter
                opt.Password.RequireUppercase = false;         // Do not require an uppercase letter
                opt.Password.RequireNonAlphanumeric = false;   // Do not require a non-alphanumeric character
                opt.Password.RequiredLength = 5;               // Set the minimum password length to 4
                opt.Password.RequiredUniqueChars = 0;          // Require at least one unique character

            })
            .AddEntityFrameworkStores<EdrsmIdentityDbContext>()
            .AddDefaultTokenProviders()
            .AddSignInManager<SignInManager<EdrsmAppUser>>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Token:Key"])),
                        ValidIssuer = config["Token:Issuer"],
                        ValidateIssuer = true,
                        ValidateAudience = false
                    };
                });


            services.AddAuthorization();

            return services;
        }
    }
        
}
