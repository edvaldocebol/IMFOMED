using projeto_test;
using projeto_test.Entidades;

namespace projeto_test.Models
{
    public class Remedio : Medicamentos
    {
        public Remedio()
        {
            listarRemedio = new List<Remedio>();
        }
        public List<Remedio> listarRemedio { get; set; }
    }
}
