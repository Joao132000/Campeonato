using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato
{
    class EquipeDados
    {
        private int idEquipe;
        private string nomeEquipe;
        private string cidadeEquipe;

        public int IdEquipe { get => idEquipe; set => idEquipe = value; }
        public string NomeEquipe { get => nomeEquipe; set => nomeEquipe = value; }
        public string CidadeEquipe { get => cidadeEquipe; set => cidadeEquipe = value; }
    }
}
