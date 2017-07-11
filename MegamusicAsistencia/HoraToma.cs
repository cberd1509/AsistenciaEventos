using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegamusicAsistencia
{
    class HoraToma
    {
        public DateTime fechatoma { get; set; }
        public string texto { get; set; }

        public HoraToma(String nombre , DateTime fechahora)
        {
            fechatoma = fechahora;
            texto = nombre;
        }

        public override string ToString()
        {
            return texto;
        }
    }
}
