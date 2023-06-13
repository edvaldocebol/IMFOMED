using Microsoft.EntityFrameworkCore;
using projeto_test.Entidades;

namespace projeto_test
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt): base (opt) 
        { }

        public DbSet<Medicamentos> Medicamentos { get; set;}
    }
}
