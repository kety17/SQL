using SistemaGURI.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGURI.DAL
{
    public class TBLODINDAO
    {

        public List<TBLOGIN> GetTodosLogins()
        {
            SqlConnection conexao = new SqlConnection(@"Server=.\SENAI2022; Database=BDJURIDICO; User Id =sa; Password=senai.123;");

            string sql = " select * from TBLOGIN";
            var dados = (List<TBLOGIN>)conexao.Query<TBLOGIN>(sql);

            return dados;
        }
    }
}
