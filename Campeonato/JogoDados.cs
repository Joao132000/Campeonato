using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato
{
    class JogoDados
    {
        private int idJogo;
        private int idEquipe1;
        private int idEquipe2;
        private int resultadoEquipe1;
        private int resultadoEquipe2;
        private int idCampeonato;
        private int idEstadio;
        private string dataJogo;

        public int IdJogo { get => idJogo; set => idJogo = value; }
        public int IdEquipe1 { get => idEquipe1; set => idEquipe1 = value; }
        public int IdEquipe2 { get => idEquipe2; set => idEquipe2 = value; }
        public int ResultadoEquipe1 { get => resultadoEquipe1; set => resultadoEquipe1 = value; }
        public int ResultadoEquipe2 { get => resultadoEquipe2; set => resultadoEquipe2 = value; }
        public int IdCampeonato { get => idCampeonato; set => idCampeonato = value; }
        public int IdEstadio { get => idEstadio; set => idEstadio = value; }
        public string DataJogo { get => dataJogo; set => dataJogo = value; }
    }
}
