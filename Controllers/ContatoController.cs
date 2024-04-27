using Microsoft.AspNetCore.Mvc;
using SiteEmMVC.Models;
using SiteEmMVC.Repository;

namespace SiteEmMVC.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepository.BuscarTodos();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }

        public IActionResult ConfirmarExclusao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato) 
        {
            _contatoRepository.Adicionar(contato);
            return RedirectToAction("Index");
        }
    }
}
