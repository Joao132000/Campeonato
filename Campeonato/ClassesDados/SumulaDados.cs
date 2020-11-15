using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Campeonato
{
    class SumulaDados
    {
        private int idSumula;
        private int idJogador;
        private int idJogo;
        private int gol;
        private string cartao;
        private string pesquisa;
        private string auxNomeJogador;

        public int IdSumula { get => idSumula; set => idSumula = value; }
        public int IdJogador { get => idJogador; set => idJogador = value; }
        public int IdJogo { get => idJogo; set => idJogo = value; }
        public int Gol { get => gol; set => gol = value; }
        public string Cartao { get => cartao; set => cartao = value; }
        public string Pesquisa { get => pesquisa; set => pesquisa = value; }
        public string AuxNomeJogador { get => auxNomeJogador; set => auxNomeJogador = value; }

        ConexaoDados obj = new ConexaoDados();

        public void InlcuirDados()
        {
            string sql = "";
            sql += "Insert into Sumula (idJogador, idJogo, gol, cartao) " +
                "values('" + IdJogador + "', '" + IdJogo
                + "','" + Gol + "','" + Cartao + "')";
            obj.Executar(sql);
        }
        public void AlterarDados()
        {
            string sql = "";
            sql += "Update Sumula set idJogador = " + IdJogador.ToString() + ", idJogo=" +
                IdJogo.ToString() + ", gol=" + Gol.ToString() + ", " +
                "cartao= '" + Cartao

                + "' where idSumula = " + IdSumula.ToString();
            obj.Executar(sql);
        }
        public void DeletarDados()
        {
            string sql = "";
            sql += "delete from Sumula where idSumula=" + IdSumula.ToString();
            obj.Executar(sql);
        }
        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from SumulaDados where Jogador LIKE'" + auxNomeJogador + "%'";
            return obj.Listar(sql);
        }
        public DataSet ListarDadosJogador()
        {
            string sql = "";
            sql = "Select * from SumulaDados ";
            return obj.Listar(sql);
        }

        public DataSet ListarDadosJogadorParaEditar()
        {
            string sql = "";
            sql = "Select * from SumulaDados where [Identificação do Jogo] = " + IdJogo.ToString();
            return obj.Listar(sql);
        }
        public void ConsultarDados()
        {
            string sql = "";
            sql = "Select * from Sumula where idSumula = " + IdSumula.ToString();
            obj.Consultar(sql);
            string[] aux = obj.Campos.Split(';');
            IdJogador = int.Parse(aux[1]);
            IdJogo = int.Parse(aux[2]);
            Gol = int.Parse(aux[3]);
            Cartao = aux[4];
        }
        public void ConsultarDadosJogo()
        {
            string sql = "";
            sql = "Select * from TimeSumula where idJogo = " + IdJogo.ToString();
            obj.Consultar(sql);
            string[] aux = obj.Campos.Split(';');
            pesquisa = aux[1];
        }
    }
}
