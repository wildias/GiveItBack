using ControleEmprestimo.DATA.Models;
using ControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace ControleEmprestimo.WEB.Controllers
{
    public class PessoaController : Controller
    {
        private PessoaService oPessoaService = new PessoaService();
        public IActionResult Index()
        {
            List<Pessoa> oListPessoa = oPessoaService.oRepositoryPessoa.SelecionarTodos();
            return View(oListPessoa);
        }
    }
}
