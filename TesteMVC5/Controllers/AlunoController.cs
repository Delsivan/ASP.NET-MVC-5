using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteMVC5.Models;

namespace TesteMVC5.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno 
        // estar pedindo uma View
        [HttpGet]
        [Route(template:"novo-aluno")]
        public ActionResult NovoAluno()
        {
            return View();
        }

        // POST: Aluno
        // Recebe os dados 
        [HttpPost]
        [Route(template: "novo-aluno")]
        public ActionResult NovoAluno(Aluno aluno)
        {
            if (!ModelState.IsValid) return View(aluno);
            return View(aluno);
        }
    }
}