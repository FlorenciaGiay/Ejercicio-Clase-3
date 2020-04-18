using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CuerpoTecnico : Persona
    {
        public bool EsTecnicoPrincipal
        {
            get
            {
                if (this.NumeroAyudanteCampo==null)
                {
                    return true;
                }
                return false;
            }
        }
        public Nullable<int> NumeroAyudanteCampo { get; set; }

        
    }
}
