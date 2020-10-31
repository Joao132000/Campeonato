using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato
{
    class CampeonatoDados
    {
        private int idCampeonato;
        private string nomeCampeonato;
        private string ano;
        private string campeao;
        private string viceCampeao;

        public int IdCampeonato { get => idCampeonato; set => idCampeonato = value; }
        public string NomeCampeonato { get => nomeCampeonato; set => nomeCampeonato = value; }
        public string Ano { get => ano; set => ano = value; }
        public string Campeao { get => campeao; set => campeao = value; }
        public string ViceCampeao { get => viceCampeao; set => viceCampeao = value; }
    }
}
