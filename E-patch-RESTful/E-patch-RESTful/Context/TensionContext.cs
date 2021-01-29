using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using E_patch_RESTful.Interfaces;
using E_patch_RESTful.Models;
using Microsoft.EntityFrameworkCore;

namespace E_patch_RESTful.Context
{
    public class TensionContext : DbContext
    {
        public TensionContext(DbContextOptions<TensionContext> options) : base(options) { }
        public DbSet<Measurement> Measurements { get; set; }
    }
}
