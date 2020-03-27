using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFramework.Bll.Abstract;
using DesafioFramework.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace DesafioFramework.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IPacienteBll _baseBll;
        private readonly IPaisBll _paisBll;

        public PacienteController(IPacienteBll baseBll, IPaisBll paisBll)
        {
            _baseBll = baseBll;
            _paisBll = paisBll;
        }

        [HttpGet("/[controller]")]
        public async Task<IActionResult> Index()
        {
            var dto = await _baseBll.GetList();
            return View(dto);
        }

        [HttpGet("/[controller]/{id}")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _baseBll.GetByIdView(int.Parse(id.ToString()));

            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }

        [HttpGet("/[controller]/create")]
        public async Task<IActionResult> Create()
        {
            PacienteDto paciente = new PacienteDto();
            paciente.pais = await _paisBll.GetList();
            return View(paciente);
        }

        [HttpPost("/[controller]/create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] PacienteDto dto)
        {
            if (ModelState.IsValid)
            {
                _baseBll.Insert(dto);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet("/[controller]/edit/{id}")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _baseBll.GetById(long.Parse(id.ToString()));
            entity.pais = _paisBll.GetList().Result;

            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }

        [HttpPut("/[controller]")]
        public IActionResult Edit([Bind]  PacienteDto dto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _baseBll.Edit(dto);
                    return Ok();
                }
                catch (Exception e)
                {
                    return StatusCode(500, e.Message);
                }
            }
            return Ok();
        }

        [HttpDelete("/[controller]/delete/{id}")]
        public IActionResult DeleteConfirmed(int? id)
        {
            try
            {
                _baseBll.Delete(long.Parse(id.ToString()));
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}