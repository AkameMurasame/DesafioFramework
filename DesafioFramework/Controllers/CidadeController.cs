using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFramework.Bll.Abstract;
using DesafioFramework.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace DesafioFramework.Controllers
{
    public class CidadeController : Controller
    {
        private readonly ICidadeBll _baseBll;
        private readonly IEstadoBll _estadoBll;

        public CidadeController(ICidadeBll baseBll, IEstadoBll estadoBll)
        {
            _baseBll = baseBll;
            _estadoBll = estadoBll;
        }

        [HttpGet("/[controller]")]
        public async Task<IActionResult> Index()
        {
            var dtos = await _baseBll.GetList();
            return View(dtos);
        }


        [HttpGet("/api/[controller]/{idEstado}")]
        public async Task<IActionResult> getCidades(int idEstado)
        {
            try
            {
                var cidades = await _baseBll.GetCidadesByEstado(idEstado);
                return new OkObjectResult(cidades);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
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
            CidadeDto cidade = new CidadeDto();
            cidade.estados = await _estadoBll.GetList();
            return View(cidade);
        }

        [HttpPost("/[controller]/create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] CidadeDto dto)
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
            entity.estados = _estadoBll.GetList().Result;

            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }

        [HttpPut("/[controller]")]
        public IActionResult Edit([Bind]  CidadeDto dto)
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
                return View();
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}