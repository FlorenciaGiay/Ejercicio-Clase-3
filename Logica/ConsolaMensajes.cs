using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public sealed class ConsolaMensajes
    {
        private static ConsolaMensajes instance = null;

        private ConsolaMensajes()
        {

        }

        public static ConsolaMensajes Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new ConsolaMensajes();
                }
                return instance;
            }
        }

        public void EscribirEnConsola(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
