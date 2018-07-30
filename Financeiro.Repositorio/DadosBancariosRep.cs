using Financeiro.Dominio.Entidades;
using Financeiro.Dominio.Interfaces;
using FInanceiro.Infra;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Financeiro.Repositorio
{
    public class DadosBancariosRep : BaseRep<DadosBancarios>, IDadosBancarios
    {
        public async Task<List<DadosBancarios>> GetByCodigoExterno(int codigoExterno)
        {
            return await new Contexto().DadosBancarios.Where(c => c.CodigoExterno == codigoExterno && c.Ativo == true).ToListAsync();
        }

        public async Task<List<DadosBancarios>> GetByCpf(string cpf)
        {
            return await new Contexto().DadosBancarios.Where(c => c.Cpf == cpf && c.Ativo == true).ToListAsync();
        }
    }

}
