using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhonebookContactManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhonebookContactManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
