using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using aws_webapp.Models;

namespace aws_webapp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Participantes> participantes { get; set; }

        public ApplicationDbContext(DbContextOptions dco) : base(dco) {

        }
    }
}
