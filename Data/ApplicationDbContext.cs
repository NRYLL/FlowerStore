
using System;
using System.Collections.Generic;
using System.Text;
using FlowerStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FlowerStore.Models;

namespace FlowerStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FlowerStore.Models.Flower> Flower { get; set; }
    }
}