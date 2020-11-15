using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Campeonato
{
    class JogoDados
    {
        private int idJogo;
        private int idEquipe1;
        private int idEquipe2;
        private int resultadoEquipe1;
        private int resultadoEquipe2;
        private int idCampeonato;
        private int idEstadio;
        private string dataJogo;
        private string pesquisa;
        private string auxJogo;

        public int IdJogo { get => idJogo; set => idJogo = value; }
        public int IdEquipe1 { get => idEquipe1; set => idEquipe1 = value; }
        public int IdEquipe2 { get => idEquipe2; set => idEquipe2 = value; }
        public int ResultadoEquipe1 { get => resultadoEquipe1; set => resultadoEquipe1 = value; }
        public int ResultadoEquipe2 { get => resultadoEquipe2; set => resultadoEquipe2 = value; }
        public int IdCampeonato { get => idCampeonato; set => idCampeonato = value; }
        public int IdEstadio { get => idEstadio; set => idEstadio = value; }
        public string DataJogo { get => dataJogo; set => dataJogo = value; }
        public string Pesquisa { get => pesquisa; set => pesquisa = value; }
        public string AuxJogo { get => auxJogo; set => auxJogo = value; }

        ConexaoDados obj = new ConexaoDados();

        public void InlcuirDados()
        {
            string sql = "";
            sql += "Insert into Jogo (idEquipe1, idEquipe2, resultadoEquipe1, resultadoEquipe2, idCampeonato, idEstadio, dataJogo) " +
                "values('" + IdEquipe1 + "', '" + IdEquipe2
                + "','" + ResultadoEquipe1 + "','" + ResultadoEquipe2 + "','" + idCampeonato + "','" + IdEstadio + "','" + DataJogo + "')";
            obj.Executar(sql);
        }

        public void AlterarDados()
        {
            string sql = "";
            sql += "Update Jogo set idEquipe1 = " + IdEquipe1.ToString() + ", idEquipe2=" +
                IdEquipe2.ToString() + ", resultadoEquipe1=" + ResultadoEquipe1.ToString() + ", " +
                "resultadoEquipe2= " + resultadoEquipe2.ToString() + ", idCampeonato=" + IdCampeonato.ToString()
                + ", idEstadio=" + IdEstadio.ToString() + ", dataJogo='" + DataJogo 
                + "' where idJogo = " + IdJogo.ToString();
            obj.Executar(sql);
        }

        public void DeletarDados()
        {
            string sql = "";
            sql += "delete from Jogo where idJogo=" + IdJogo.ToString();
            obj.Executar(sql);
        }

        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from Jogo";
            return obj.Listar(sql);
        }
        public DataSet PesquisarPorCampeonato()
        {
            string sql = "";
            sql = "Select * from JogosConsulta where Campeonato like '%"+Pesquisa+"%'";
            return obj.Listar(sql);
        }
        public DataSet ListarDadosEdicao()
        {
            string sql = "";
            sql = "Select * from JogosConsulta";
            return obj.Listar(sql);
        }
        public DataSet ListarDadosEquipeJogo()
        {
            string sql = "";
            sql = "Select * from ListarTimeJogo where idJogo = " + IdJogo.ToString();
            return obj.Listar(sql);
        }

        public DataSet ListarDadosNomeJogo()
        {
            string sql = "";
            sql = "Select * from TimeSumula where idCampeonato = " + IdCampeonato.ToString();
            return obj.Listar(sql);
        }
        public void ConsultarDados()
        {
            string sql = "";
            sql = "Select * from Jogo where idJogo = " + IdJogo.ToString();
            obj.Consultar(sql);
            string[] aux = obj.Campos.Split(';');
            IdEquipe1 = int.Parse(aux[1]);
            IdEquipe2 = int.Parse(aux[2]);
            ResultadoEquipe1 = int.Parse(aux[3]);
            ResultadoEquipe2 = int.Parse(aux[4]);
            IdCampeonato = int.Parse(aux[5]);
            IdEstadio = int.Parse(aux[6]);
            DataJogo = aux[7];
        }
        public DataSet ListarDadosJogo()
        {
            string sql = "";
            sql = "Select * from TimeSumula";
            return obj.Listar(sql);
        }
        public void ConsultarDadosJogo()
        {
            string sql = "";
            sql = "Select * from TimeSumula where idJogo = " + IdJogo.ToString();
            obj.Consultar(sql);
            string[] aux = obj.Campos.Split(';');
            AuxJogo = aux[1];
            }
    }
}
