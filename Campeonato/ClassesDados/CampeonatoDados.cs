using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Campeonato
{
    class CampeonatoDados
    {
        private int idCampeonato;
        private string nomeCampeonato;
        private string ano;
        private string tipoCampeonato;
        private string campeao;
        private string viceCampeao;

        public int IdCampeonato { get => idCampeonato; set => idCampeonato = value; }
        public string NomeCampeonato { get => nomeCampeonato; set => nomeCampeonato = value; }
        public string Ano { get => ano; set => ano = value; }
        public string Campeao { get => campeao; set => campeao = value; }
        public string ViceCampeao { get => viceCampeao; set => viceCampeao = value; }
        public string TipoCampeonato { get => tipoCampeonato; set => tipoCampeonato = value; }

        ConexaoDados obj = new ConexaoDados();

        public void InlcuirDados()
        {
            string sql = "";
            sql += "Insert into Campeonato (nomeCampeonato, ano, tipoCampeonato) " +
                "values('" + NomeCampeonato + "', '" + Ano
                + "','" + TipoCampeonato + "')";
            obj.Executar(sql);
        }


        public void AlterarDados()
        {
            string sql = "";
            sql += "Update Campeonato set nomeCampeonato = '" + NomeCampeonato + "', ano='" +
                Ano +  "', tipoCampeonato='" + TipoCampeonato
                + "' where idCampeonato = " + IdCampeonato.ToString();
            obj.Executar(sql);
        }

        public void AlterarDadosCampeao_Vice()
        {
            string sql = "";
            sql += "Update Campeonato set campeao = '" + Campeao + "', viceCampeao='" +
                ViceCampeao +  "' where idCampeonato = " + IdCampeonato.ToString();
            obj.Executar(sql);
        }

        public void DeletarDados()
        {
            string sql = "";
            sql += "delete from Campeonato where idCampeonato=" + IdCampeonato.ToString();
            obj.Executar(sql);
        }

        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from Campeonato";
            return obj.Listar(sql);
        }

        public DataSet ListarDadosParaConsulta()
        {
            string sql = "";
            sql = "Select * from Campeonato where nomeCampeonato like'" + NomeCampeonato + "%'";
            return obj.Listar(sql);
        }

        public void ConsultarDados()
        {
            string sql = "";
            sql = "Select * from Campeonato where idCampeonato = " + IdCampeonato.ToString();
            obj.Consultar(sql);
            string[] aux = obj.Campos.Split(';');
            NomeCampeonato = aux[1];
            Ano = aux[2];
            TipoCampeonato = aux[3];
            Campeao = aux[4];
            ViceCampeao = aux[5];

        }

        public void ConsultarDadosCampeao_Vice()
        {
            string sql = "";
            sql = "Select * from Campeonato where idCampeonato = " + IdCampeonato.ToString();
            obj.Consultar(sql);
            string[] aux = obj.Campos.Split(';');
            Campeao = aux[4];
            ViceCampeao = aux[5];

        }
    }
}
