using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPT.Controllers
{
    public class PessoaController : Controller
    {
        private readonly Contexto _contexto;

        public PessoaController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Pessoas.ToListAsync());

        }

        [HttpGet]
        public IActionResult CriarPessoa()
        {
            ViewBag.Enderecos = new SelectList(_contexto.Enderecos, "EnderecoId", "Logradouro");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarPessoa(Pessoa Pessoa)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(Pessoa);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Pessoa);
        }

        [HttpPost]
        public void CriarPessoaUpload(IEnumerable<IFormFile> DocumentPhotos)
        {
            var a = DocumentPhotos;
        }

        [HttpGet]
        public IActionResult AtualizarPessoa(int? id)
        {
            ViewBag.Enderecos = new SelectList(_contexto.Enderecos, "EnderecoId", "Logradouro");
            if (id != null)
            {
                Pessoa Pessoa = _contexto.Pessoas.Find(id);
                return View(Pessoa);
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarPessoa(int? id, Pessoa Pessoa)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(Pessoa);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View(Pessoa);
            }

            else
                return NotFound();
        }

        [HttpGet]
        public IActionResult ExcluirPessoa(int? id)
        {
            if (id != null)
            {
                Pessoa Pessoa = _contexto.Pessoas.Find(id);
                return View(Pessoa);
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirPessoa(int? id, Pessoa Pessoa)
        {
            if (id != null)
            {
                _contexto.Remove(Pessoa);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                
            }
            else
                return NotFound();
        }
    }
}
