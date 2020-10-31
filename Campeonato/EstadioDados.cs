using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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

        ConexaoDados obj = new ConexaoDados();

        public void IncluirDados()
        {
            string sql = "";
            sql += "Insert into Estadio (nomeEstadio, Estado) values ('" + NomeEstadio + "','" + Estado + "')";
            obj.Executar(sql);
        }

        public void AlterarDados()
        {
            string sql = "";
            sql += "Update Estadio set nomeEstadio = '" + NomeEstadio + "', Estado='" + Estado + "' where idEstadio= " + IdEstadio.ToString();
            obj.Executar(sql);
        }

        public void DeletarDados()
        {
            string sql = "";
            sql += "delete from Estadio where idEstadio=" + IdEstadio.ToString();
            obj.Executar(sql);
        }

        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from Estadio";
            return obj.Listar(sql);
        }

        public void ConsultarDados()
        {
            string sql = "";
            sql = "Select * from Estadio where idEstadio = " + IdEstadio.ToString();
            obj.Consultar(sql);
            string[] aux = obj.Campos.Split(';');
            NomeEstadio = aux[1];
            Estado = aux[2];

        }
    }
}
