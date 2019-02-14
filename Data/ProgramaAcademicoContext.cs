using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProgramaAcademico.Models
{
    public class ProgramaAcademicoContext : DbContext
    {
        public ProgramaAcademicoContext (DbContextOptions<ProgramaAcademicoContext> options)
            : base(options)
        {
        }

        public DbSet<ProgramaAcademico.Models.Categoria> Categoria { get; set; }
    }
}