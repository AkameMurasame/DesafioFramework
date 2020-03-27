using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFramework.Bll.Abstract;
using DesafioFramework.Models.Dto;
using DesafioFramework.Models.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioFramework.Controllers
{
    public class PaisController : Controller
    {
        private readonly IPaisBll _baseBll;

        public PaisController(IPaisBll baseBll)
        {
            _baseBll = baseBll;
        }

        [HttpGet("/[controller]")]
        public async Task<IActionResult> Index()
        {
            var paises = await _baseBll.GetList();
            return View(paises);
        }

        [HttpGet("/[controller]/{id}")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pais = _baseBll.GetById(long.Parse(id.ToString()));

            if (pais == null)
            {
                return NotFound();
            }
            return View(pais);
        }


        [HttpGet("/[controller]/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/[controller]/create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] PaisDto pais)
        {
            if (ModelState.IsValid)
            {
                _baseBll.Insert(pais);
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

            var pais = _baseBll.GetById(long.Parse(id.ToString()));

            if (pais == null)
            {
                return NotFound();
            }
            return View(pais);
        }

        [HttpPut("/[controller]")]
        public IActionResult Edit([Bind]  PaisDto dto)
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
            return StatusCode(StatusCodes.Status428PreconditionRequired);
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