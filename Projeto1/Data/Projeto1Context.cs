using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Projeto1.Models
{
    public class Projeto1Context : DbContext
    {
        public Projeto1Context (DbContextOptions<Projeto1Context> options)
            : base(options)
        {
        }

        public DbSet<Projeto1.Models.Usuario> Usuario { get; set; }
    }
}
