using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchAdmin___Camada_de_Dados.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace ChurchAdmin___Camada_de_Dados
{
    public class ConexaoSql
    {
        private const string _strCon = @"Data Source=SDV-Alex;Initial Catalog=CHURCHWINBD000;Integrated Security=True";
        SqlConnection objCon = null;

        public bool conectar()
        {
            objCon = new SqlConnection(_strCon);
            try
            {
                objCon.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public SqlConnection ObterConexao()
        {
            if (objCon == null)
            {
                conectar();
            }
           if (objCon.State == System.Data.ConnectionState.Closed)
            {
                objCon.Open();
            }
            return objCon;
        }

        public void FecharConexao()
        {
            if (objCon.State == System.Data.ConnectionState.Open)
            {
                objCon.Close();
            }
        }

        public void Dispose()
        {
            this.FecharConexao();
        }
    }
}
