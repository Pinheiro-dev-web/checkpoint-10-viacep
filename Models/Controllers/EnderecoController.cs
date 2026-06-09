using Microsoft.AspNetCore.Mvc;
using CadastroAlunos.Models;

namespace CadastroAlunos.Controllers
{
    public class EnderecoController : Controller
    {
        // 1. Apresenta o formulário inicial
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Endereco());
        }

        // 2. Recebe os dados da view via Model Binding e redireciona
        [HttpPost]
        public IActionResult Salvar(Endereco endereco)
        {
            // Redireciona para a view de somente leitura passando o objeto preenchido
            return View("Resultado", endereco);
        }
    }
}
