using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpFinanceiro.Domains.Generics
{
    public interface IDomain<T> where T : class
    {
        IEnumerable<T> Inserir(IEnumerable<T> entities);
        IEnumerable<T> Alocar(IEnumerable<T> entities);
        bool LiberarPagamento(int idCliente, int codigoExterno);
    }
}
