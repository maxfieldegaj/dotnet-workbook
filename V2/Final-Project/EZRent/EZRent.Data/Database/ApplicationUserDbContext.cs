﻿using EZRent.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EZRent.Data.Database
{
    public class ApplicationUserDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationUserDbContext(DbContextOptions<ApplicationUserDbContext> options)
            : base(options)
        { }
    }
}
