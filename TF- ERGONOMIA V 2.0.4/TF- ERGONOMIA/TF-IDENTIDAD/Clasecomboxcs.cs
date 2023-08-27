using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.ENTITIES
{
    public class ComboBoxOption
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }

        public ComboBoxOption(string nombre, int numero)
        {
            Nombre = nombre;
            Numero = numero;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
