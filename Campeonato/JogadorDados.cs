using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato
{
    class JogadorDados
    {
        private int idJogador;
        private int idEquipe;
        private string nomeJogador;
        private string dataNascimento;
        private string numeroCamisa;

        public int IdJogador { get => idJogador; set => idJogador = value; }
        public int IdEquipe { get => idEquipe; set => idEquipe = value; }
        public string NomeJogador { get => nomeJogador; set => nomeJogador = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string NumeroCamisa { get => numeroCamisa; set => numeroCamisa = value; }



    }
}
