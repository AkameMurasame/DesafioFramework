using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFramework.Bll.Abstract;
using DesafioFramework.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesafioFramework.Controllers
{
    public class EstadoController : Controller
    {
        private readonly IEstadoBll _baseBll;
        private readonly IPaisBll _paisBll;

        public EstadoController(IEstadoBll baseBll, IPaisBll paisBll)
        {
            _baseBll = baseBll;
            _paisBll = paisBll;
        }

        [HttpGet("/[controller]")]
        public async Task<IActionResult> Index()
        {
            var paises = await _baseBll.GetList();
            return View(paises);
        }

        [HttpGet("/api/[controller]/{idPais}")]
        public async Task<IActionResult> getEstados(int idPais)
        {
            var estados = await _baseBll.GetEstadosByPais(idPais);
            return new OkObjectResult(estados);
        }

        [HttpGet("/[controller]/{id}")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _baseBll.GetByIdView(long.Parse(id.ToString()));

            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }

        [HttpGet("/[controller]/create")]
        public async Task<IActionResult> Create()
        {
            EstadoDto estado = new EstadoDto();
            estado.paises = await _paisBll.GetList();
            return View(estado);
        }

        [HttpPost("/[controller]/create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] EstadoDto dto)
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
            entity.paises = _paisBll.GetList().Result;
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }

        [HttpPut("/[controller]")]
        public IActionResult Edit([Bind]  EstadoDto dto)
        {
            if (ModelState.IsValid)
            {
                _baseBll.Edit(dto);
                return Ok();
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