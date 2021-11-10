using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AcompanhamentoPlanoCarreira.Models.ViewModels;

namespace AcompanhamentoPlanoCarreira.Data
{
    public class AcompanhamentoPlanoCarreiraContext : DbContext
    {
        public AcompanhamentoPlanoCarreiraContext (DbContextOptions<AcompanhamentoPlanoCarreiraContext> options)
            : base(options)
        {
        }

        public DbSet<AcompanhamentoPlanoCarreira.Models.ViewModels.Department> Department { get; set; }
    }
}
