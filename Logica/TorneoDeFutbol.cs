using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class TorneoDeFutbol
    {
        public static List<Partido> Partidos { get; set; }

        public static string PartidoEnJuego { get; set; }

        public static bool NuevoPartido(Arbitro arbitro, string ciudad, Equipo equipoLocal, Equipo equipoVisitante)
        {
            List<Arbitro> arbitros = new List<Arbitro>();
            arbitros.Add(arbitro);

            Partido nuevoPartido = new Partido()
            {
                Arbitros = arbitros,
                EquipoLocal = equipoLocal,
                EquipoVisitante = equipoVisitante
            };
            nuevoPartido.GuardarCiudadPartido(ciudad);
            PartidoEnJuego = $"{equipoLocal.Nombre} vs {equipoVisitante.Nombre}";

            Partidos.Add(nuevoPartido);

            return true;
        }


    }
}
