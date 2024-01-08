using System;

namespace TF.ENTITIES
{
    public class Rula
    {
        public int cargaId { get; set; }
        public string CUIT { get; set; }
        public string PuestoDeTrabajo { get; set; }
        public string FechaCarga { get; set; }
        public string FechaCarga2 { get; set; }
        public int Brazo { get; set; }
        public int Antebrazo { get; set; }
        public int Muneca { get; set; }
        public int Giro { get; set; }
        public int Actividadmusculara { get; set; }
        public int Cargafuerzaa { get; set; }
        public int Cuellob { get; set; }
        public int Tronco { get; set; }
        public int Piernas { get; set; }
        public int Actividadmuscularb { get; set; }
        public int Cargafuerzab { get; set; }
        public int puntuacionRula { get; set; }
        public int niveldeRiesgo { get; set; }
        public string ResultadoAnalisisRula { get; set; }
        public string DniEmpleadoRula { get; set; }
        public string EmpleadoRula { get; set; }
        public string EmpresaRula { get; set; }

        // Resultados VALOR Tablas A, B y C //

        public int ValorA { get; set; }
        public int ValorB { get; set; }
        public int ValorC { get; set; }

        public int ValorTablaA { get; set; }
        public int ValorTablaB { get; set; }
    }
}
