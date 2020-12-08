using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace mvc.Controllers
{

    [Route("academy/admin")]
    public class AdminController : Controller
    {
        [HttpGet("main/{token}/{nome}")]
        public IActionResult Index(string token, string nome){
            return Content("Admin Controller " + nome + " token : " + token);
        }

        [HttpGet("company")]
        public IActionResult company(){
            var name = Request.Query["name"];
            return Content("My first day at company! "+ name);
        }

        [HttpGet("view")]
        public IActionResult visualizar(){
            ViewData["autenticado"] = false;
            return View();
        }

        [HttpGet("form")]
        public IActionResult form(){
            return View();
        }

        [HttpPost("data")]
        public IActionResult data(){
            StringValues name;
            StringValues email;

            Request.Form.TryGetValue("name", out name);
            Request.Form.TryGetValue("email", out email);
            return Content("Formulário enviado com sucesso! " + "\n nome "+ name + "\n email "+ email );
        }
    }
}