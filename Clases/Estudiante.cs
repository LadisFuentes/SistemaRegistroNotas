
namespace SistemaRegistroNotas.Clases
{
    public class Estudiante
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Codigo { get; set; }

        public decimal Laboratorio { get; set; }

        public decimal Parcial { get; set; }

        public decimal Asistencia { get; set; }

        public decimal NotaFinal { get; set; }
    }
}
