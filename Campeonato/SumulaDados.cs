using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato
{
    class SumulaDados
    {
        private int idSumula;
        private int idJogador;
        private int idJogo;
        private int gol;
        private string cartao;

        public int IdSumula { get => idSumula; set => idSumula = value; }
        public int IdJogador { get => idJogador; set => idJogador = value; }
        public int IdJogo { get => idJogo; set => idJogo = value; }
        public int Gol { get => gol; set => gol = value; }
        public string Cartao { get => cartao; set => cartao = value; }
    }
}
