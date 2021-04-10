using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPT.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly Contexto _contexto;

        public FuncionariosController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            return View( await _contexto.Funcionarios.ToListAsync());
        }

        [HttpGet]
        public IActionResult CriarFuncionario()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarFuncionario(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(funcionario);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }

        [HttpGet]
        public IActionResult AtualizarFuncionario(int? id)
        {
            if (id != null)
            {
                Funcionario Funcionario =  _contexto.Funcionarios.Find(id);
                return View(Funcionario);
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarFuncionario(int? id, Funcionario funcionario)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(funcionario);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View(funcionario);
            }
                
            else
                return NotFound();
        }

        [HttpGet]
        public IActionResult ExcluirFuncionario(int? id)
        {
            if (id != null)
            {
                Funcionario Funcionario = _contexto.Funcionarios.Find(id);
                return View(Funcionario);
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirFuncionario(int? id, Funcionario funcionario)
        {
            if (id != null)
            {
                try
                {
                    _contexto.Remove(funcionario);
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
            ViewBag.ErrorMessage = "Falha na exclusão! \r\nExistem registros vinculados a este Funcionário!";
            return View();
        }
    }
}
