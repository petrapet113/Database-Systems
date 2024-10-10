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
    public class LekController : Controller
    {
        [HttpGet]
        [Route("VratiSveLekove")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult VratiSveLekove()
        {
            try
            {
                var lekovi = DataProvider.VratiSveLekove();
                return Ok(lekovi.Select(p=>new
                {
                    p.Id,
                    p.HemijskiNaziv,
                    p.KomercijalniNaziv,
                    p.DozaDeca,
                    p.DozaOdrasli,
                    p.DozaTrudnice,
                    p.Cena
                }));

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        [Route("VratiKontraindikacijeZaLek/{idLeka}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult VratiKontraindikacijeLeka(int idLeka)
        {
            try
            {
                var lekovi = DataProvider.VratiKontraindikacije(idLeka);
                return Ok(lekovi);

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [HttpGet]
        [Route("VratiNeželjeneEfekte/{idLeka}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult VratiNeželjeneEfekte(int idLeka)
        {
            try
            {
                var lekovi = DataProvider.VratiNeželjeneEfekte(idLeka);
                return Ok(lekovi);

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        [Route("DodajLek")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajLek(int DozaDeca, int DozaOdrasli, int DozaTrudnice, string KomercijalniNaziv, string HemijskiNaziv, int Cena,string primarnaGrupa, string imeProizvodjaca)
        {
            try
            {
                DataProvider.DodajLek(DozaDeca, DozaOdrasli, DozaTrudnice, KomercijalniNaziv, HemijskiNaziv, Cena,primarnaGrupa, imeProizvodjaca);
                return Ok("Uspesno ste dodali lek");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [HttpPost]
        [Route("DodajLekProdajnomMestu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajLekProdajnomMestu(int idLeka, int idProdMesta, int kolicina)
        {
            try
            {
                DataProvider.DodajLekProdajnomMestu(idLeka, idProdMesta, kolicina);
                return Ok("Uspesno ste dodali lek prodajnom mestu");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [HttpPost]
        [Route("DodajPakovanjeLeku/{idLeka}/{tipPakovanja}/{sastav}/{kolicina}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajLekProdajnomMestu(int idLeka, string tipPakovanja,string sastav, int kolicina)
        {
            try
            {
                DataProvider.DodajSePakuje(idLeka,tipPakovanja,sastav,kolicina);
                return Ok("Uspesno ste dodali pakovanje leku");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajLek")]

        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult UpdateLek(int id, string komercijalninaziv, string hemijskinaziv,
                            int dozadeca, int dozaodrasli, int dozatrudnice, int cena)
        {
            try
            {
                DataProvider.AzurirajLek(id,komercijalninaziv,hemijskinaziv,dozadeca,dozaodrasli,dozatrudnice,cena);
                return Ok("Uspesno ste azurirali lek");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiLek/{idLeka}")]

        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ObrisiLek(int idLeka)
        {
            try
            {
                DataProvider.ObrisiLek(idLeka);
                return Ok("Uspesno ste obrisali lek");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }

        }
        [HttpPost]
        [Route("DodajNezeljeneEfekteLeku/{idLeka}/{efekti}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajNezeljeneEfekte(int idLeka, string efekti)
        {
            try
            {
                DataProvider.DodajNezeljeneEfekte(idLeka,efekti);
                return Ok("Uspesno ste dodali nezeljene efekte");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [HttpPost]
        [Route("DodajKontraindikacijuLeku/{idLeka}/{kontraindikacije}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajKontraindikacijeLeku(int idLeka, string kontraindikacije)
        {
            try
            {
                DataProvider.DodajKontraindikacijeLeku(idLeka, kontraindikacije);
                return Ok("Uspesno ste dodali kontraindikacije");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        [HttpDelete]
        [Route("ObrisiLekIzProdajnogMesta/{idLeka}/{idProdMesta}")]

        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ObrisiLek(int idLeka,int idProdMesta)
        {
            try
            {
                DataProvider.ObrisiLekProdajnomMestu(idLeka,idProdMesta);
                return Ok("Uspesno ste obrisali lek iz prodajnog mesta");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }

        }

    }
}
