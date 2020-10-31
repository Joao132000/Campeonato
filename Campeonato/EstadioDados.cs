using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato
{
    class EstadioDados
    {
        private int idEstadio;
        private string nomeEstadio;
        private string estado;

        public int IdEstadio { get => idEstadio; set => idEstadio = value; }
        public string NomeEstadio { get => nomeEstadio; set => nomeEstadio = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
