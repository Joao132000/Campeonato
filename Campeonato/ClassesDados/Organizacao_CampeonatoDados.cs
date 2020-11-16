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

        public void ConsultarDados()
        {
            string sql = "";
            sql = "Select * from Organizacao_Campeonato where idCampeonato = " + IdCampeonato.ToString();
            obj.Consultar(sql);
            string[] aux = obj.Campos.Split(';');
            IdCampeonato = int.Parse(aux[0]);
            IdEquipe = int.Parse(aux[1]);
            Pontos = int.Parse(aux[2].ToString());
        }

        public void ConsultarDadosCampeonatoEquipe()
        {
            string sql = "";
            sql = "Select * from Organizacao_Campeonato where idCampeonato = " + IdCampeonato.ToString()+" and idEquipe = " + IdEquipe.ToString();
            obj.Consultar(sql);
            string[] aux = obj.Campos.Split(';');
            IdCampeonato = int.Parse(aux[0]);
            IdEquipe = int.Parse(aux[1]);
            Pontos = int.Parse(aux[2].ToString());
        }
        public void AlterarDados()
        {
            string sql = "";
            sql += "Update Organizacao_Campeonato set pontos = '" + Pontos + "' where idEquipe= " + IdEquipe.ToString();
            obj.Executar(sql);
        }

        public DataSet ListarDadosParaConsulta()
        {
            string sql = "";
            sql = "Select Equipe.nomeEquipe, pontos from Organizacao_Campeonato inner join Equipe on Organizacao_Campeonato.idEquipe = Equipe.idEquipe " +
                "where idCampeonato =" + IdCampeonato + " Order by pontos desc";
            return obj.Listar(sql);
        }

        public DataSet ListarDadosParaComboBox()
        {
            string sql = "";
            sql = "Select Equipe.idEquipe, Equipe.nomeEquipe from Organizacao_Campeonato inner join Equipe on Organizacao_Campeonato.idEquipe = Equipe.idEquipe " +
                "where idCampeonato =" + IdCampeonato;
            return obj.Listar(sql);
        }
    }
}
