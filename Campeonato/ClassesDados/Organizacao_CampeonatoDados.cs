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
        public string NomeCampeonato { get => nomeCampeonato; set => nomeCampeonato = value; }
        public string NomeEquipe { get => nomeEquipe; set => nomeEquipe = value; }
        public int Pontos { get => pontos; set => pontos = value; }

        ConexaoDados obj = new ConexaoDados();

        public void IncluirDados()
        {
            string sql = "";
            sql += "Insert into Organizacao_Campeonato (idCampeonato, nomeCampeonato, idEquipe, nomeEquipe) " +
                "values ('" + IdCampeonato + "','" + nomeCampeonato + "','" + IdEquipe + "','" +NomeEquipe +"')";
            obj.Executar(sql);
        }

        public DataSet ListarDadosParaConsulta()
        {
            string sql = "";
            sql = "Select * from Organizacao_Campeonato where nomeCampeonato like'" + nomeCampeonato + "%'";
            return obj.Listar(sql);
        }
    }
}
