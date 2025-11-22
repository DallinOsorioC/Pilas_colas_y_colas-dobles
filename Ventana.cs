using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_colas_y_colas_dobles
{
    public class Ventana
    {
        public string NombreVentana { get; set; } = "";
        public DateTime HoraCreacion { get; set; } = DateTime.Now;
        public string Usuario { get; set; } = "";

        public override string ToString() => $"{NombreVentana}: {HoraCreacion} ({Usuario})";
    }
}
