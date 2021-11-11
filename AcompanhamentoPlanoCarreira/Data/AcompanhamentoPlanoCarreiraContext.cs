using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AcompanhamentoPlanoCarreira.Models.ViewModels;
using AcompanhamentoPlanoCarreira.Models;

namespace AcompanhamentoPlanoCarreira.Data
{
    public class AcompanhamentoPlanoCarreiraContext : DbContext
    {
        public AcompanhamentoPlanoCarreiraContext (DbContextOptions<AcompanhamentoPlanoCarreiraContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }

        public DbSet<Seller> Seller { get; set; }

        public DbSet<SallesRecord> SallesRecord { get; set; }
    }
}
