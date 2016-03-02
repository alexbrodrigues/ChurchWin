using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchAdmin___Camada_de_Dados.Interfaces
{
    interface IConexaoBD<T>:IDisposable
    {
        T ObterConexao();

        void FecharConexao();
    }
}
