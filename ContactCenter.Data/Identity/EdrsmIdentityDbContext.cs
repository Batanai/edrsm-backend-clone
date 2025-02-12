﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCenter.Data.Identity
{
    public class EdrsmIdentityDbContext : IdentityDbContext<EdrsmAppUser>
    {
        public EdrsmIdentityDbContext(DbContextOptions<EdrsmIdentityDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Customize table names
            builder.Entity<EdrsmAppUser>(entity => entity.ToTable("EdrsmAppUser"));
            builder.Entity<IdentityRole>(entity => entity.ToTable("EdrsmRoles"));
            builder.Entity<IdentityUserRole<string>>(entity => entity.ToTable("EdrsmUserRoles"));
            builder.Entity<IdentityUserClaim<string>>(entity => entity.ToTable("EdrsmUserClaims"));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.ToTable("EdrsmUserLogins"));
            builder.Entity<IdentityRoleClaim<string>>(entity => entity.ToTable("EdrsmRoleClaims"));
            builder.Entity<IdentityUserToken<string>>(entity => entity.ToTable("EdrsmUserTokens"));
        }
    }
}
