using System;
using System.Web.Mvc;
using TesteMVC5.Data;
using TesteMVC5.Models;

namespace TesteMVC5.Controllers
{
    public class AlunoController : Controller
    {
        private readonly AppDbContext context = new AppDbContext();

        // GET: Aluno 
        // estar pedindo uma View
        [HttpGet]
        [Route("novo-aluno")]
        public ActionResult NovoAluno()
        {
            return View();
        }

        // POST: Aluno
        // Recebe os dados 
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("novo-aluno")]
        public ActionResult NovoAluno(Aluno aluno)
        {
            if (!ModelState.IsValid) return View(aluno);

            aluno.DataMatricula = DateTime.Now;

            context.Alunos.Add(aluno);
            context.SaveChanges();

            // algumas regras de negocio + salvar no banco

            return View(aluno);
        }
    }
}