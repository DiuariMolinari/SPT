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
    public class PessoaEnderecosController : Controller
    {
        private readonly Contexto _contexto;

        public PessoaEnderecosController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (id != null && id != 0)
            {
                return View(await _contexto.PessoaEnderecos.Where(x => x.PessoaId == id).Include(x => x.Pessoa).Include(x => x.Endereco).ToListAsync());
            }
            return View(await _contexto.PessoaEnderecos.Include(x => x.Pessoa).Include(x => x.Endereco).ToListAsync());
        }

        [HttpGet]
        public IActionResult CriarPessoaEnderecos()
        {
            ViewBag.Enderecos = new SelectList(_contexto.Enderecos, "EnderecoId", "Logradouro");
            ViewBag.Pessoas = new SelectList(_contexto.Pessoas, "PessoaId", "Nome");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarPessoaEnderecos(PessoaEnderecos PessoaEndereco)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(PessoaEndereco);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(PessoaEndereco);
        }

        [HttpGet]
        public IActionResult AtualizarPessoaEnderecos(int? id)
        {
            ViewBag.Enderecos = new SelectList(_contexto.Enderecos, "EnderecoId", "Logradouro");
            ViewBag.Pessoas = new SelectList(_contexto.Pessoas, "PessoaId", "Nome");
            if (id != null)
            {
                PessoaEnderecos PessoaEnderecos = _contexto.PessoaEnderecos.Find(id);
                return View(PessoaEnderecos);
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarPessoaEnderecos(int? id, PessoaEnderecos PessoaEndereco)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(PessoaEndereco);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View(PessoaEndereco);
            }

            else
                return NotFound();
        }

        [HttpGet]
        public IActionResult ExcluirPessoaEnderecos(int? id)
        {
            if (id != null)
            {
                PessoaEnderecos PessoaEndereco = _contexto.PessoaEnderecos.Include(x => x.Pessoa).Include(x => x.Endereco).First(x => x.PessoaEnderecosId == id);
                return View(PessoaEndereco);
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirPessoaEnderecos(int? id, PessoaEnderecos PessoaEndereco)
        {
            if (id != null)
            {
                try
                {
                    _contexto.Remove(PessoaEndereco);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception e)
                {
                    return RedirectToAction(nameof(Error));
                }
            }
            else
                return NotFound();
        }

        [HttpGet]
        public IActionResult Error()
        {
            ViewBag.ErrorMessage = "Falha na exclusão! Existem outros registros vinculados a este!";
            return View();
        }
    }
}
