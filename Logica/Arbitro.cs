using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Arbitro : Persona
    {
        public TipoArbitro TipoArbitro { get; set; }

        public override bool ProximaARetiro()
        {
            if (this.Edad.HasValue)
            {
                return this.Edad.Value >= 36 || this.Edad.Value < 38;
            }
            else
            {
                throw new Exception("Edad no tiene valor");
            }

        }
    }
}
