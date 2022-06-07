using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using Numerador.Entities;

namespace Numerador.Services
{
    class Conexao
    {

        private const string Provider = @"Provider = Microsoft.Jet.OLEDB.4.0;";
        private const string Path = @"\\DSSRV08\PROJETOS$\ERICK\Numerador\BDEnum.mdb";
        private string strConn = Provider + "Data Source=" + Path;

        OleDbConnection Conn;

        public Conexao()
        {
            Conn = new OleDbConnection(strConn);
        }

        public OleDbConnection AbrirConexao()
        {
            if(Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }            
            return Conn;
        }

        public void FecharConexao()
        {
            Conn.Close();
        }
    }
}
