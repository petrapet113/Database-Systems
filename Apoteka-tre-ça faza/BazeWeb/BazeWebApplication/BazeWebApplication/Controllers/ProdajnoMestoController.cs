using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DatabaseAccess;
using System;
using System.Runtime.InteropServices;
using DatabaseAccess.Entiteti;
using DatabaseAccess.DTOs;

namespace BazeWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdajnoMestoController : ControllerBase
    {
        [HttpGet]
        [Route("VratiProdMesta")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult VratiProdMesta()
        {
            try
            {
                var prodavnice = DataProvider.VratiSvaProdMesta();
                return Ok(prodavnice);
                //return new JsonResult(DataProvider.VratiSvaProdMesta());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajProdajnoMesto/{naziv}/{ulica}/{broj}/{grad}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajProdMesto(string naziv, string ulica, int broj, string grad)
        {
            try
            {
                DataProvider.DodajProdajnoMesto(naziv,ulica,broj,grad);
                return Ok("Uspesno ste dodali prodajno mesto");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajProdajnoMesto/{id}/{naziv}/{ulica}/{broj}/{grad}")]
        
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult UpdateProdMesto(int id,string naziv, string ulica, int broj, string grad)
        {
            try
            {
                DataProvider.AzurirajProdajnoMesto(id,naziv, ulica, broj, grad);
                return Ok("Uspesno ste azurirali prodajno mesto");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiProdajnoMesto/{idProdMesta}")]

        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ObrisiProdajnoMesto(int idProdMesta)
        {
            try
            {
                DataProvider.ObrisiProdajnoMesto(idProdMesta);
                return Ok("Uspesno ste obrisali prodajno mesto");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }

        }

    }
}
