﻿using Microsoft.AspNetCore.Mvc;
using Poke.Mongo.Api.Models.Documents;
using Poke.Mongo.Api.Services;
using System.Collections.Generic;

namespace Poke.Mongo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly VeiculoService _veiculoService;

        public VeiculoController(VeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        [HttpGet("{id:length(24)}", Name = "GetVeiculo")]
        public ActionResult<Veiculo> Get(string id)
        {
            var veiculo = _veiculoService.Get(id);

            if (veiculo == null)
            {
                return NotFound();
            }

            return veiculo;
        }

        [HttpGet(Name = "GetVeiculos")]
        public ActionResult<IList<Veiculo>> Get()
        {
            var veiculos = _veiculoService.Get();

            if (veiculos == null)
            {
                return NotFound();
            }

            return veiculos;
        }

        [HttpPost]
        public ActionResult<Veiculo> Create(Veiculo veiculo)
        {
            _veiculoService.Create(veiculo);

            return CreatedAtRoute("GetVeiculo", new { id = veiculo.Id.ToString() }, veiculo);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Veiculo veiculoNovo)
        {
            var veiculo = _veiculoService.Get(id);

            if (veiculo == null)
            {
                return NotFound();
            }

            _veiculoService.Update(id, veiculoNovo);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var veiculo = _veiculoService.Get(id);

            if (veiculo == null)
            {
                return NotFound();
            }

            _veiculoService.Remove(veiculo.Id);

            return NoContent();
        }
    }
}