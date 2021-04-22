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

        public async Task<IActionResult> Index(DateTime minDate, DateTime maxDate)
        {
            double totalGasto = 0;
            List<FolhaPagamento> folhas;
            if (minDate != null && maxDate != null && minDate != DateTime.MinValue && maxDate != DateTime.MinValue)
            {
                folhas = await _contexto.FolhaPagamentos.Where(x => x.Periodo > minDate && x.Periodo < maxDate).ToListAsync();
                ViewBag.minDate = minDate.ToString("yyyy-MM-dd");
                ViewBag.maxDate = maxDate.ToString("yyyy-MM-dd");
            }

            else
                folhas = await _contexto.FolhaPagamentos.ToListAsync();

            foreach (var folha in folhas)
            {
                folha.Funcionario = _contexto.Funcionarios.Find(folha.FuncionarioId);
                totalGasto += folha.Funcionario.ValorHora * folha.HorasTrabalhadas;
            }

            ViewBag.TotalGasto = totalGasto;
            return View(folhas);
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

        public IActionResult IndexChart()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Chart()
        {
            var folhas = _contexto.FolhaPagamentos.ToList();
            double totalGasto = 0;
            Dictionary<string, double> valorPorPerido = new Dictionary<string, double>();

            foreach (var folha in folhas)
            {
                folha.Funcionario = _contexto.Funcionarios.Find(folha.FuncionarioId);

                var periodo = folha.Periodo.ToString("MMM/yyyy");
                var valor = folha.Funcionario.ValorHora * folha.HorasTrabalhadas;
                if (valorPorPerido.ContainsKey(periodo))
                    valorPorPerido[periodo] += valor;
                else
                    valorPorPerido.Add(periodo, valor);
            }

            var result = new
            {
                labels = valorPorPerido.Keys.ToArray(),
                values = valorPorPerido.Values.ToArray()
            };

            return Json(result);
        }
    }
}
