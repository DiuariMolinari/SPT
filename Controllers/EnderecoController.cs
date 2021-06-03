using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SPT.Controllers
{
    public class EnderecoController : Controller
    {
        private readonly Contexto _contexto;

        public EnderecoController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Enderecos.ToListAsync());
        }

        [HttpGet]
        public IActionResult CriarEndereco()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarEndereco(Endereco Endereco)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(Endereco);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Endereco);
        }

        [HttpGet]
        public IActionResult AtualizarEndereco(int? id)
        {
            if (id != null)
            {
                Endereco Endereco = _contexto.Enderecos.Find(id);
                return View(Endereco);
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarEndereco(int? id, Endereco Endereco)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(Endereco);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View(Endereco);
            }

            else
                return NotFound();
        }

        [HttpGet]
        public IActionResult ExcluirEndereco(int? id)
        {
            if (id != null)
            {
                Endereco Endereco = _contexto.Enderecos.Find(id);
                return View(Endereco);
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirEndereco(int? id, Endereco Endereco)
        {
            if (id != null)
            {
                _contexto.Remove(Endereco);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            else
                return NotFound();
        }

        //Exemplo de consumo de api com asp.net core
        //No caso eu fiz com Js/Jquery

        //public async Task<IActionResult> GetAddressByCep(string cep)
        //{
        //    Endereco endereco = new Endereco();
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("https://api.postmon.com.br/");
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        HttpResponseMessage response = await client.GetAsync($"v1/cep/{cep}");
        //        if (response.IsSuccessStatusCode)
        //        {
        //            endereco = await response.Content.ReadAsAsync<Endereco>();
        //        }
        //    }

        //    return Ok(endereco);
        //}
    }
}
