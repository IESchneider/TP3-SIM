using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_SIM.Entidades
{
    internal class Fila
    {
        // Atributos del vector de estado para cada fila. Se utilizarán dos objetos filas.
        public int Persona { get; set; }
        public string RNDRta1 { get; set; }
        public string Recordaba { get; set; }
        public string RNDRta2 { get; set; }
        public string Compra1 { get; set; }
        public string RNDRta3 { get; set; }
        public string Compra2 { get; set; }
        public int CantCompras { get; set; }
    }
}
