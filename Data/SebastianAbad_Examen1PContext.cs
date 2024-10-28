using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SebastianAbad_Examen1P.Models;

namespace SebastianAbad_Examen1P.Data
{
    public class SebastianAbad_Examen1PContext : DbContext
    {
        public SebastianAbad_Examen1PContext (DbContextOptions<SebastianAbad_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<SebastianAbad_Examen1P.Models.SA_Carro> SA_Carro { get; set; } = default!;
    }
}
