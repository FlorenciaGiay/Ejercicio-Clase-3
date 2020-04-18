using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public partial class Equipo
    {
        public int Presupuesto { get; private set; }

        public void CalcularPresupuesto()
        {
            this.Presupuesto = Jugadores.Count()*15000+CuerpoTecnico.Count(x=>x.EsTecnicoPrincipal==true)*30000+CuerpoTecnico.Count(x=>x.EsTecnicoPrincipal==false)*10000;
        }
    }
}
