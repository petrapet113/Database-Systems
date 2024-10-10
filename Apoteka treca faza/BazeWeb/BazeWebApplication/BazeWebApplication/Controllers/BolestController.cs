using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Http;
using DatabaseAccess;

namespace BazeWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BolestController : Controller
    {
        [HttpGet]
        [Route("VratiBolestZaOdrejeniLek")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult VratiBolestLeku(int idLeka)
        {
            try
            {
                var bolesti = DataProvider.VratiBolestLeku(idLeka);
                return Ok(bolesti.Select(p => new
                {
                    naziv=p.Naziv
                }));
                
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [HttpGet]
        [Route("VratiSveBolesti")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult VratiSveBolesti()
        {
            try
            {
                var bolesti = DataProvider.VratiSveBolesti();
                return Ok(bolesti.Select(p => new
                {
                    p.Id,
                    p.Naziv
                })) ;
                //return new JsonResult(DataProvider.VratiSveBolesti());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }


        }

        [HttpPost]
        [Route("DodajBolestLeku/{idBolesti}/{idLeka}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajBolestLeku(int idBolesti, int idLeka)
        {
            try
            {
                DataProvider.DodajBolestLeku(idBolesti,idLeka);
                return Ok("Uspesno ste dodali bolest");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [HttpPost]
        [Route("DodajBolest")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajBolest([FromBody] BolesDodaj bolest)
        {
            try
            {
                DataProvider.DodajBolest(bolest);
                return Ok("Uspesno ste dodali bolest");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [HttpDelete]
        [Route("ObrisiBolest/{idBolesti}")]

        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ObrisiBolest(int idBolesti)
        {
            try
            {
                DataProvider.ObrisiBolest(idBolesti);
                return Ok("Uspesno ste obrisali bolest");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }

        }
        [HttpPut]
        [Route("AzurirajBolest")]

        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult UpdateBolest([FromBody] BolesDodaj bolest)
        {
            try
            {
                DataProvider.AzurirajBolest(bolest);
                return Ok("Uspesno ste azurirali bolest");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}
