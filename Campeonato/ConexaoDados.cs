using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Campeonato
{
    class ConexaoDados
    {
        private SqlConnection cn = new SqlConnection();
        private SqlCommand cd = new SqlCommand();

        private void Conectar()
        {
            string s = "";
            s = @"Server=.\SQLEXPRESS01;Database=Futebol;UID=sa;PWD=123";
            cn.ConnectionString = s;
            cn.Open();
        }

        public void Executar(string sql)
        {
            Conectar();
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }

        public DataSet Listar(string sql)
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            return ds;
        }

        private string campos;
        public string Campos { get => campos; set => campos = value; }

        public void Consultar(string sql)
        {
            Conectar();
            cd.Connection = cn;
            cd.CommandText = sql;
            SqlDataReader dr = cd.ExecuteReader();
            campos = "";
            if (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    Campos += dr[i].ToString() + ";";

                }
            }
            cn.Close();
        }
    }
}

