using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SPT.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
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
            var file = Request.Form.Files[0];
            var textFile = GetStringFromFile(file);
            if (file.FileName.Contains("Adryan"))
            {
                TextFileToObjectAdryan(textFile);
            }
            else
                TextFileToObject(textFile);
        }

        private void TextFileToObjectAdryan(string textFile)
        {
            var pessoasString = textFile.Split("\r\n").ToList();
            List<Pessoa> pessoas = new List<Pessoa>();

            for (int i = 0; i < pessoasString.Count - 1; i++)
            {
                var properties = pessoasString[i].Split("|");
                var nome = properties[0];
                var dataNascimento = properties[3];
                var cpf = properties[1];

                pessoas.Add(new Pessoa(nome, DateTime.Parse(dataNascimento), cpf));
            }

            if (pessoas.Count > 0)
            {
                _contexto.AddRange(pessoas);
                _contexto.SaveChanges();
            }
        }

        private void TextFileToObject(string textFile)
        {
            var pessoasString = textFile.Split("\r\n").ToList();
            List<Pessoa> pessoas = new List<Pessoa>();

            for (int i = 0; i < pessoasString.Count - 1; i++)
            {
                var properties = pessoasString[i].Split("&");
                var nome = properties[0];
                var dataNascimento = properties[1];
                var cpf = properties[2];

                pessoas.Add(new Pessoa(nome, DateTime.Parse(dataNascimento), cpf));
            }

            if (pessoas.Count > 0)
            {
                _contexto.AddRange(pessoas);
                _contexto.SaveChanges();
            }
        }

        private string GetStringFromFile(IFormFile file)
        {
            var result = new StringBuilder();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    result.AppendLine(reader.ReadLine());
            }
            return result.ToString();
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
