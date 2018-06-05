using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    class Paciente
    {
        public string NombrePaciente { get; set; }
        public long NumeroDocumento { get; set; }
        public byte Rango { get; set; }
        public string TipoDocumento { get; set; }
        public long Costos { get; set; }
    }
}
