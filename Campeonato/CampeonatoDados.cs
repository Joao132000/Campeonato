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
            sql += "Insert into Campeonato (nomeCampeonato, ano, campeao, viceCampeao, tipoCampeonato) " +
                "values('" + NomeCampeonato + "', '" + Ano
                + "','" + Campeao + "','" + ViceCampeao + "','" + TipoCampeonato + "')";
            obj.Executar(sql);
        }

        public void AlterarDados()
        {
            string sql = "";
            sql += "Update Campeonato set nomeCampeonato = '" + NomeCampeonato + "', ano=" +
                Ano + ", campeao='" + Campeao + "', " +
                "viceCampeao= " + ViceCampeao + ", tipoCampeonato='" + TipoCampeonato
                + "where idproduto = " + IdCampeonato.ToString();
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

        public void ConsultarDados()
        {
            string sql = "";
            sql = "Select * from Campeonato where idCampeonato = " + IdCampeonato.ToString();
            obj.Consultar(sql);
            string[] aux = obj.Campos.Split(';');
            NomeCampeonato = aux[1];
            Ano = aux[2];
            Campeao = aux[3];
            ViceCampeao = aux[4];
            TipoCampeonato = aux[5];
        }
    }
}
