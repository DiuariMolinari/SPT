using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SPT.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace SPT.Controllers
{
    public class FolhaPagamentoController : Controller
    {
        private readonly Contexto _contexto;

        public FolhaPagamentoController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            double totalGasto = 0;
            foreach (var folha in _contexto.FolhaPagamentos)
            {
                folha.Funcionario = _contexto.Funcionarios.Find(folha.FuncionarioId);
                totalGasto += folha.Funcionario.ValorHora * folha.HorasTrabalhadas;
            }

            ViewBag.TotalGasto = totalGasto;
            return View(await _contexto.FolhaPagamentos.ToListAsync());
        }

        [HttpGet]
        public IActionResult CriarFolhaPagamento()
        {
            ViewBag.Funcionarios = new SelectList(_contexto.Funcionarios, "FuncionarioId", "Nome");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarFolhaPagamento(FolhaPagamento FolhaPagamento)
        {
            var funcionarioId = int.Parse(Request.Form["FuncionarioId"][0]);
            if (ModelState.IsValid && FolhaPagamento.FuncionarioId > 0)
            {
                _contexto.Add(FolhaPagamento);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(FolhaPagamento);
        }

        [HttpGet]
        public IActionResult AtualizarFolhaPagamento(int? id)
        {
            ViewBag.Funcionarios = new SelectList(_contexto.Funcionarios, "FuncionarioId", "Nome");
            if (id != null)
            {
                FolhaPagamento FolhaPagamento = _contexto.FolhaPagamentos.Find(id);
                return View(FolhaPagamento);
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarFolhaPagamento(int? id, FolhaPagamento FolhaPagamento)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(FolhaPagamento);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View(FolhaPagamento);
            }

            else
                return NotFound();
        }

        [HttpGet]
        public IActionResult ExcluirFolhaPagamento(int? id)
        {
            if (id != null)
            {
                FolhaPagamento FolhaPagamento = _contexto.FolhaPagamentos.Find(id);
                return View(FolhaPagamento);
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirFolhaPagamento(int? id, FolhaPagamento FolhaPagamento)
        {
            if (id != null)
            {
                _contexto.Remove(FolhaPagamento);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
                return NotFound();
        }
    }
}
