﻿using Microsoft.AspNetCore.Mvc;
using Poke.Mongo.Api.Models.Documents;
using Poke.Mongo.Api.Services;
using System.Collections.Generic;

namespace Poke.Mongo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParadaController : ControllerBase
    {
        private readonly ParadaService _paradaService;

        public ParadaController(ParadaService paradaService)
        {
            _paradaService = paradaService;
        }

        [HttpGet("{id:length(24)}", Name = "GetParada")]
        public ActionResult<Parada> Get(string id)
        {
            var parada = _paradaService.Get(id);

            if (parada == null)
            {
                return NotFound();
            }

            return parada;
        }

        [HttpGet(Name = "GetParadas")]
        public ActionResult<IList<Parada>> Get()
        {
            var paradas = _paradaService.Get();

            if (paradas == null)
            {
                return NotFound();
            }

            return paradas;
        }

        [HttpPost]
        public ActionResult<Parada> Create(Parada parada)
        {
            _paradaService.Create(parada);

            return CreatedAtRoute("GetParada", new { id = parada.Id.ToString() }, parada);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Parada paradaNovo)
        {
            var parada = _paradaService.Get(id);

            if (parada == null)
            {
                return NotFound();
            }

            _paradaService.Update(id, paradaNovo);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var parada = _paradaService.Get(id);

            if (parada == null)
            {
                return NotFound();
            }

            _paradaService.Remove(parada.Id);

            return NoContent();
        }
    }
}