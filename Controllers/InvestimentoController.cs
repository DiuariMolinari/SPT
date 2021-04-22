using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPT.Controllers
{
    public class InvestimentoController : Controller
    {
        private readonly Contexto _contexto;

        public InvestimentoController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            var investimentos = _contexto.Investimentos.ToList();
            Dictionary<double, string> valoresFinais = new Dictionary<double, string>();
            foreach (var item in investimentos)
                valoresFinais.Add(item.InvestimentoId, CalculaInvestimento(item).ToString("C"));

            ViewBag.valoresFinais = valoresFinais;
            return View(investimentos);
        }

        [HttpGet]
        public IActionResult CriarInvestimento()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarInvestimento(Investimento Investimento)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(Investimento);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Investimento);
        }

        [HttpGet]
        public IActionResult AtualizarInvestimento(int? id)
        {
            if (id != null)
            {
                Investimento Investimento = _contexto.Investimentos.Find(id);
                return View(Investimento);
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarInvestimento(int? id, Investimento Investimento)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(Investimento);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View(Investimento);
            }

            else
                return NotFound();
        }

        [HttpGet]
        public IActionResult ExcluirInvestimento(int? id)
        {
            if (id != null)
            {
                Investimento Investimento = _contexto.Investimentos.Find(id);
                return View(Investimento);
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirInvestimento(int? id, Investimento Investimento)
        {
            if (id != null)
            {
                _contexto.Remove(Investimento);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
                return NotFound();
        }


        [HttpPost]
        public ActionResult SugerirTipoInvestimento(double periodo, double valor)
        {
            if (periodo != 0 && valor != 0)
            {
                Dictionary<string, double> aplicacoes = new Dictionary<string, double>();

                var valorPoupança = InvestimentoPoupança(periodo, valor);
                aplicacoes.Add("Poupança", valorPoupança);

                var valorAplicacao = InvestimentoAplicacao(periodo, valor);
                aplicacoes.Add("Aplicação", valorAplicacao);

                var valorProducao = InvestimentoProducao(periodo, valor);
                aplicacoes.Add("Produção", valorProducao);


                var maiorValor = aplicacoes.Values.Max();
                var tipoInvestimento = aplicacoes.FirstOrDefault(x => x.Value == maiorValor).Key;
                
                string outrosInvestimentos = "";
                foreach (var item in aplicacoes.Where(x => x.Value != maiorValor))
                    outrosInvestimentos += $"\r\n{item.Key} = {item.Value.ToString("C")}";

                var result = new
                {
                    tipoInvestimento = tipoInvestimento,
                    detalhesInvestimento = $"{maiorValor.ToString("C")}",
                    outrosInvestimentos = outrosInvestimentos,
                };

                return Json(result);
            }
            else
                return BadRequest();
        }

        private double CalculaInvestimento(Investimento investimento)
        {
            switch (investimento.TipoInvestimento)
            {
                case TipoInvestimento.Poupança:
                    {
                        return InvestimentoPoupança(investimento.Periodo, investimento.ValorInvestido);
                    }
                case TipoInvestimento.Aplicação:
                    {
                        return InvestimentoAplicacao(investimento.Periodo, investimento.ValorInvestido);
                    }
                case TipoInvestimento.Produção:
                    {
                        return InvestimentoProducao(investimento.Periodo, investimento.ValorInvestido);
                    }
                default:
                    return 0;
            }
        }

        private double InvestimentoProducao(double periodo, double valor)
        {
            const double custoTotalMaquina = 4380;
            const double lucroPorMaquina = 3120;

            var  qtdMaquinas = Math.Floor((valor / custoTotalMaquina));
            if (qtdMaquinas < 1)
                return valor;

            var restanteValor = valor % custoTotalMaquina;
            var lucroTotal = qtdMaquinas * lucroPorMaquina;

           
            return (lucroTotal * periodo) + restanteValor;
        }

        private double InvestimentoAplicacao(double periodo, double valor)
        {
            double valorFinal = valor;
            if (valor <= 100000)
            {
                for (int i = 0; i < periodo; i++)
                    valorFinal += valorFinal * (0.5 / 100);
            }
            else
            {
                for (int i = 0; i < periodo; i++)
                    valorFinal += valorFinal * (0.8 / 100);
            }

            double lucro = valorFinal - valor;
            double IR = CalculaValorIR(lucro);

            return valorFinal - IR;
        }

        private double InvestimentoPoupança(double periodo, double valor)
        {
            for (int i = 0; i < periodo; i++)
                valor += valor * (0.15 / 100);

            return valor;
        }

        private double CalculaValorIR(double valor)
        {
            if (valor <= 1039)
                return valor * (0.75 / 100);

            else if (valor <= 2098)
                return valor * (0.9 / 100);

            else if (valor <= 3134)
                return valor * (0.12 / 100);

            else
                return valor * (0.14 / 100);
        }
    }
}
