using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Extenciones
    {
        public static List<string> FiltrarListaDeIncidenciasPorGol(this List<string> listadoDescripciones)
        {
            return listadoDescripciones.FindAll(x => x.Contains("GOL"));
        }
    }
}
