using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcfService;
using Newtonsoft.Json;

namespace SPT.Controllers
{
    public class ConsorcioController : Controller
    {
        private readonly Contexto _contexto;

        public ConsorcioController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Consorcios = await _contexto.Consorcios.ToListAsync();
            return View();
        }

        [HttpGet]
        public IActionResult CriarConsorcio()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarConsorcio(Consorcio Consorcio)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(Consorcio);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Consorcio);
        }

        [HttpGet]
        public IActionResult AtualizarConsorcio(int? id)
        {
            if (id != null)
            {
                Consorcio Consorcio = _contexto.Consorcios.Find(id);
                return View(Consorcio);
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarConsorcio(int? id, Consorcio Consorcio)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(Consorcio);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View(Consorcio);
            }

            else
                return NotFound();
        }

        [HttpGet]
        public IActionResult ExcluirConsorcio(int? id)
        {
            if (id != null)
            {
                Consorcio Consorcio = _contexto.Consorcios.Find(id);
                return View(Consorcio);
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirConsorcio(int? id, Consorcio Consorcio)
        {
            if (id != null)
            {
                _contexto.Remove(Consorcio);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                
            }
            else
                return NotFound();
        }

        [HttpGet]
        public IActionResult GetValorParcela()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetValorParcela(double valorCarta, double taxa, int parcelas)
        {
            var valorParcela = new ConsorcioService().GetValorParcela(valorCarta, taxa, parcelas);
            ViewBag.ValorCarta = valorCarta;
            ViewBag.Taxa = taxa;
            ViewBag.Parcelas = parcelas;
            ViewBag.valorParcelas = valorParcela;

            return View();
        }

        [HttpGet]
        public JsonResult GetConsorcios(double valorCarta, double taxa, int parcelas)
        {
            List<ResponseConsorcio> consorcios = new List<ResponseConsorcio>();
            consorcios.Add(new ResponseConsorcio("Teste 1", "Carro 1", 10000, "Rua Amazonas", "89076869"));
            consorcios.Add(new ResponseConsorcio("Teste 2", "Carro 2", 30000, "Rua Antônio da Veiga", "89576238"));

            return Json(consorcios);
        }
    }
}
