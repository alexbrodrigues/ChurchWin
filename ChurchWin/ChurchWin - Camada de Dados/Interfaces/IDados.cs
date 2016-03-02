using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchAdmin___Camada_de_Dados.Interfaces
{
    interface IDados<Dado> :IDisposable
    {
        bool Inserir(Dado objeto);
        bool Alterar(Dado objeto);
        bool Excluir(Dado objeto);
        Dado Buscar(string id);

        Collection<Dado> ObterTodos();
    }
}
