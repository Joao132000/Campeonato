using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Campeonato
{
    //Alfenas
    class EquipeDados
    {
        private int idEquipe;
        private string nomeEquipe;
        private string cidadeEquipe;
        private byte[] foto;


        public int IdEquipe { get => idEquipe; set => idEquipe = value; }
        public string NomeEquipe { get => nomeEquipe; set => nomeEquipe = value; }
        public string CidadeEquipe { get => cidadeEquipe; set => cidadeEquipe = value; }
        public byte[] Foto { get => foto; set => foto = value; }

        ConexaoDados obj = new ConexaoDados();

        public void IncluirDados()
        {
            string sql = "";
            sql += "Insert into Equipe (nomeEquipe, cidadeEquipe,Foto) values ('" + NomeEquipe + "','" + CidadeEquipe + "',@BINARIO)";
            obj.ExecutarFoto(sql,Foto);
        }
        
        public void AlterarDados()
        {
            string sql = "";
            sql += "Update Equipe set nomeEquipe = '" + NomeEquipe + "', cidadeEquipe='" + CidadeEquipe + "',Foto = @BINARIO where idEquipe= " + IdEquipe.ToString();
            obj.ExecutarFoto(sql,Foto);
        }

        public void DeletarDados()
        {
            string sql = "";
            sql += "delete from Equipe where idEquipe=" + IdEquipe.ToString();
            obj.Executar(sql);
        }

        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from Equipe";
            return obj.Listar(sql);
        }

        public void ConsultarDados()
        {
            string sql = "";
            sql = "Select * from Equipe where idEquipe = " + IdEquipe.ToString();
            obj.Consultar(sql);
            string[] aux = obj.Campos.Split(';');
            NomeEquipe = aux[1];
            CidadeEquipe = aux[2];

        }
        public void ConsultarFoto()
        {
            string sql = "Select * from Equipe where idEquipe = " + IdEquipe.ToString();
            obj.ConsultarImagem(sql, ref foto);
            string[] aux = obj.Campos.Split(';');
            nomeEquipe = aux[1];
            cidadeEquipe = aux[2]; 
        }

    }
}
