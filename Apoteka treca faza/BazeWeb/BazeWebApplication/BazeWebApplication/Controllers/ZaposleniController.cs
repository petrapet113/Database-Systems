using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazeWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZaposleniController : Controller
    {

        [HttpGet]
        [Route("VratiSveZaposlene")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult VratiSveZaposlene()
        {
            try
            {
                var zaposleni = DataProvider.VratiSveZaposlene();
                
                return Ok(zaposleni.Select(p=>new
                {
                    p.JMBG,
                    p.Ime,
                    p.Prezime,
                    p.Ulica,
                    p.Broj,
                    p.Grad,
                    p.DatumRođenja
                }));
                //return new JsonResult(DataProvider.VratiSveZaposlene());
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }

        }

        [HttpPost]
        [Route("DodajZaposlenog/{jmbg}/{ime}/{prezime}/{datum}/{ulica}/{grad}/{broj}/{idProdMesta}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajZaposlenog(long jmbg, string ime, string prezime, DateTime datum, string ulica ,string grad, int broj, int idProdMesta)
        {
            try
            {
                DataProvider.DodajZaposlenog(jmbg,ime,prezime,datum,ulica,grad,broj, idProdMesta);
                return Ok("Uspesno ste dodali zaposlenog");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("VratiZaposleneNaOvomProdMestu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult VratiZaposleneNaOvomProdMestu(int idProdMesta)
        {
            try
            {
                var zaposleni = DataProvider.VratiZaposleneNaOvomProdMestu(idProdMesta);
                return Ok(zaposleni.Select(z => new
                {
                    JMBG = z.JMBG,
                    Ime = z.Ime,
                    Prezime = z.Prezime,
                    Ulica = z.Ulica,
                    Grad = z.Grad,
                    Broj = z.Broj,
                    DatumRođenja = z.DatumRođenja
                }));
            
                
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }


        }

        [HttpPut]
        [Route("AzurirajZaposlenog/{jmbg}/{ime}/{prezime}/{datum}/{ulica}/{grad}/{broj}/{idProdMesta}")]

        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult UpdateZaposlenog(long jmbg, string ime, string prezime, DateTime datum, string ulica, string grad, int broj,int idProdMesta)
        {
            try
            {
                DataProvider.AzurirajZaposlenog(jmbg, ime, prezime, datum, ulica, grad, broj, idProdMesta);
                return Ok("Uspesno ste azurirali zaposlenog");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        

        [HttpPost]
        [Route("DodajZaposlenogProdajnomMestu/{idProdMesta}/{idZaposlenog}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajZaposlenogProdajnomMestu(int idProdMesta, long idZaposlenog)
        {
            try
            {
                DataProvider.DodajZaposlenogProdajnomMestu(idProdMesta, idZaposlenog);
                return Ok("Uspesno ste dodali zaposlenog prodajnom mestu");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        


        [HttpDelete]
        [Route("ObrisiZaposlenog/{idZaposlenog}")]

        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ObrisiZaposlenog(long idZaposlenog)
        {
            try
            {
                DataProvider.ObrisiZaposlenog(idZaposlenog);
                return Ok("Uspesno ste obrisali zaposlenog");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }

        }

    }


}
