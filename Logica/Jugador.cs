using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Jugador : Persona
    {
        public int Numero { get; set; }
        public bool EsTitular
        {
            get
            {
                if (this.Numero <= 11)
                {
                    return true;
                }
                return false;
            }
        }
        public Equipo Equipo { get; set; }
        public Posicion Posicion { get; set; }

        
        public override bool ProximaARetiro()
        {
            try
            {
                return this.Edad.Value >= 36 || this.Edad.Value < 38;
            }
            catch
            {
                throw new Exception("Edad no tiene valor");
            }
        }
    }
}
