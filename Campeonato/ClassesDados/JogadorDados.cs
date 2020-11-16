using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Campeonato
{
    class JogadorDados
    {
        private int idJogador;
        private int idEquipe;
        private string nomeJogador;
        private string dataNascimento;
        private int numeroCamisa;

        public int IdJogador { get => idJogador; set => idJogador = value; }
        public int IdEquipe { get => idEquipe; set => idEquipe = value; }
        public string NomeJogador { get => nomeJogador; set => nomeJogador = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public int NumeroCamisa { get => numeroCamisa; set => numeroCamisa = value; }

        ConexaoDados obj = new ConexaoDados();

        public void InlcuirDados()
        {
            string sql = "";
            sql += "Insert into Jogador (idEquipe, nomeJogador, dataNascimento, numeroCamisa) " +
                "values('" + IdEquipe + "', '" + NomeJogador
                + "','" + DataNascimento + "','" + NumeroCamisa + "')";
            obj.Executar(sql);
        }

        public void AlterarDados()
        {
            string sql = "";
            sql += "Update Jogador set idEquipe = '" + IdEquipe.ToString() + "', nomeJogador='" +
                NomeJogador + "', dataNascimento='" + DataNascimento + "', " +
                "numeroCamisa= " + NumeroCamisa.ToString()
                + "where idJogador = " + IdJogador.ToString();
            obj.Executar(sql);
        }

        public void DeletarDados()
        {
            string sql = "";
            sql += "delete from Jogador where idJogador=" + IdJogador.ToString();
            obj.Executar(sql);
        }

        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from Jogador";
            return obj.Listar(sql);
        }

        public DataSet PesquisarJogador()
        {
            string sql = "";
            sql = "Select * from Jogador where nomeJogador Like '"+nomeJogador+"%'";
            return obj.Listar(sql);
        }
        public DataSet ListarDadosJogador()
        {
            string sql = "";
            sql = "Select * from Jogador order by idEquipe";
            return obj.Listar(sql);
        }
        public DataSet ListarDadosJogadorporEquipe()
        {
            string sql = "";
            sql = "Select * from Jogador where idEquipe=" + IdEquipe.ToString();
            return obj.Listar(sql);
        }

        public void ConsultarDados()
        {
            string sql = "";
            sql = "Select * from Jogador where idJogador = " + IdJogador.ToString();
            obj.Consultar(sql);
            string[] aux = obj.Campos.Split(';');
            IdEquipe = int.Parse(aux[1]);
            NomeJogador = aux[2];
            DataNascimento = aux[3];
            NumeroCamisa = int.Parse(aux[4]);
        }

    }
}

    

