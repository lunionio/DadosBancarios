using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Dominio.Entidades;
using Financeiro.Servico;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Aplicacao.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [EnableCors("AllowAll")]
    public class DadosBancariosController : Controller
    {

        [HttpGet(Name = "Get")]
        public async Task<List<DadosBancarios>> Get()
        {
            return await new DadosBancariosServico().GetAll();
        }

        [HttpGet("{cpf}", Name = "GetByCpf")]
        public async Task<List<DadosBancarios>> GetByCpfAsync(string cpf)
        {
            return await new DadosBancariosServico().GetByCpfAsync(cpf);
        }

        [HttpPost("{conta}", Name = "GetByCpf")]
        public int Cadastrar(DadosBancarios conta)
        {
            return new DadosBancariosServico().Cadastrar(conta);
        }
        [HttpPost("{conta}", Name = "Alterar")]
        public string Alterar(DadosBancarios conta)
        {
            return new DadosBancariosServico().Alterar(conta);
        }

    }
}