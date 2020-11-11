using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Campeonato
{
    class Organizacao_CampeonatoDados
    {
        private int idCampeonato;
        private int idEquipe;
        private string nomeCampeonato;
        private string nomeEquipe;
        private int pontos;

        public int IdCampeonato { get => idCampeonato; set => idCampeonato = value; }
        public int IdEquipe { get => idEquipe; set => idEquipe = value; }
        public int Pontos { get => pontos; set => pontos = value; }

        ConexaoDados obj = new ConexaoDados();

        public void IncluirDados()
        {
            string sql = "";
            sql += "Insert into Organizacao_Campeonato (idCampeonato, idEquipe) " +
                "values ('" + IdCampeonato + "','" + IdEquipe  +"')";
            obj.Executar(sql);
        }

        public DataSet ListarDadosParaConsulta()
        {
            string sql = "";
            sql = "Select Equipe.nomeEquipe, pontos from Organizacao_Campeonato inner join Equipe on Organizacao_Campeonato.idEquipe = Equipe.idEquipe " +
                "where idCampeonato =" + IdCampeonato + " Order by pontos desc";
            return obj.Listar(sql);
        }
    }
}
