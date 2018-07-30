using Financeiro.Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Financeiro.Dominio.Interfaces
{
    public interface IDadosBancarios
    {
        Task<List<DadosBancarios>> GetByCodigoExterno(int codigoExterno);
        Task<List<DadosBancarios>> GetByCpf(string cpf);
    }
}
