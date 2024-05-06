using Microsoft.AspNetCore.Mvc;

namespace CursoDesenvolvimentoWeb.controllers
{
    public class TesteController : Controller
    {

        private readonly ILogger<TesteController> _logger;

        public TesteController(ILogger<TesteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(string name, string password)
        {
            string receiveName = name;
            string receivePassword = password;

            //salvar o banco de dados
            return View();
        }
    }

}