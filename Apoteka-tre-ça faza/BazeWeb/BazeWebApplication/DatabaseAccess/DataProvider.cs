using System;
using NHibernate;
using NHibernate.Event.Default;
using System.Web;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.DTOs;
using System.Linq;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess
{
    public class DataProvider
    {
        #region ProdMesta
        public static async Task<Result<List<ProdajnoMestoView>, string>> VratiSvaOdeljenjaAsync()
        {
            List<ProdajnoMestoView> data = new List<ProdajnoMestoView>();

            ISession s = null;

            try
            {
                s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                data = (await s.QueryOver<ProdajnoMesto>().ListAsync())
                               .Select(p => new ProdajnoMestoView(p)).ToList();
            }
            catch (Exception)
            {
                return "Došlo je do greške prilikom prikupljanja informacija o odeljenjima.";
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return data;
        }
        public static List<ProdajnoMestoView> VratiSvaProdMesta()
        {
            List<ProdajnoMestoView> prodajnaMesta = new List<ProdajnoMestoView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProdajnoMesto> svaProdMesta = from o in s.Query<ProdajnoMesto>()
                                                          select o;

                foreach (ProdajnoMesto p in svaProdMesta)
                {
                    prodajnaMesta.Add(new ProdajnoMestoView(p.Id, p.Naziv, p.Ulica, p.Grad, p.Broj));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return prodajnaMesta;

        }
        //obrisi prodajno mesto
        public static void ObrisiProdajnoMesto(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DatabaseAccess.Entiteti.ProdajnoMesto o = s.Load<DatabaseAccess.Entiteti.ProdajnoMesto>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        //dodaj prodajno mesto
        public static void DodajProdajnoMesto(string naziv, string ulica, int broj, string grad)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var novoProdajnoMesto = new ProdajnoMesto();
                novoProdajnoMesto.Naziv = naziv;
                novoProdajnoMesto.Ulica = ulica;
                novoProdajnoMesto.Grad = grad;
                novoProdajnoMesto.Broj = broj;

                s.SaveOrUpdate(novoProdajnoMesto);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }

        //auriraj prodajno mesto
        public static void AzurirajProdajnoMesto(int id,string naziv, string ulica, int broj, string grad)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProdajnoMesto o = s.Load<ProdajnoMesto>(id);
                o.Naziv = naziv;
                o.Grad = grad;
                o.Ulica = ulica;
                o.Broj = broj;


                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        #endregion
        #region Zaposleni
        

        public static List<ZaposleniView> VratiSveZaposlene()
        {
            List<ZaposleniView> zaposleni = new List<ZaposleniView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zaposleni> sviZaposleni = from o in s.Query<Zaposleni>()
                                                      select o;

                foreach (Zaposleni z in sviZaposleni)
                {
                    zaposleni.Add(new ZaposleniView(z.JMBG, z.Ime, z.Prezime, z.Ulica, z.Grad, z.Broj, z.DatumRođenja, z.RadiUProdMesto.Naziv));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return zaposleni;

        }

        public static void DodajZaposlenog(long jmbg, string ime, string prezime, DateTime datum, string ulica,string grad, int broj, int idProdMesta)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni o = new Zaposleni();

                o.JMBG = jmbg;
                o.Ime = ime;
                o.Prezime = prezime;
                o.DatumRođenja = datum;
                o.Ulica = ulica;
                o.Broj = broj;
                o.Grad = grad;
                ProdajnoMesto a = s.Load<ProdajnoMesto>(idProdMesta);
                o.RadiUProdMesto = a;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static List<int> VratiBrojeveTelefona(long idZaposlenog)
        {
            List<int> brojevitelefona = new List<int>();
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(idZaposlenog);



                foreach (ZaposleniBrTel zbr in z.BrojeviTelefonaZaposlenog)
                {
                    brojevitelefona.Add(zbr.Id.BrTelefonaZaposlenog);
                }

                s.Close();


            }
            catch (Exception ec)
            {
                //handle exceptions
                //return string.Empty;
            }
            return brojevitelefona;
        }

        public static List<Zaposleni> VratiZaposleneNaOvomProdMestu(int idProdMesta)
        {
            List<Zaposleni> zaposleni = new List<Zaposleni>();
            try
            {
                ISession s = DataLayer.GetSession();

                ProdajnoMesto p = s.Load<ProdajnoMesto>(idProdMesta);

                foreach (Zaposleni z in p.Zaposleni)
                {
                    zaposleni.Add(new Zaposleni(z.JMBG, z.Ime, z.Prezime, z.Ulica, z.Grad, z.Broj, z.DatumRođenja));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return zaposleni;
        }

        public static void AzurirajZaposlenog(long jmbg, string ime, string prezime, DateTime datum, string ulica, string grad, int broj,int idProdMesta)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zaposleni o = new Zaposleni();
                o.JMBG = jmbg;
                o.Ime = ime;
                o.Prezime = prezime;
                o.DatumRođenja = datum;
                o.Ulica = ulica;
                o.Broj = broj;
                o.Grad = grad;
                ProdajnoMesto a = s.Load<ProdajnoMesto>(idProdMesta);
                o.RadiUProdMesto = a;


                s.SaveOrUpdate(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }

        public static void ObrisiZaposlenog(long idZaposlenog)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zaposleni zap = s.Load<Zaposleni>(idZaposlenog);
                zap.RadiUProdMesto = null;
                zap.BrojeviTelefonaZaposlenog = null;

                s.Delete(zap);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }


        public static void DodajZaposlenogProdajnomMestu(int idProdMesta, long idZaposlenog)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(idZaposlenog);

                ProdajnoMesto prodajnoMesto = s.Load<ProdajnoMesto>(idProdMesta);
                z.RadiUProdMesto = prodajnoMesto;


                s.SaveOrUpdate(z);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion
        #region Bolest
        public static List<BolestView> VratiSveBolesti()
        {
            List<BolestView> bolesti = new List<BolestView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Bolest> sveBolesti = from o in s.Query<Bolest>()
                                                  select o;

                foreach (Bolest z in sveBolesti)
                {
                    bolesti.Add(new BolestView(z.Id, z.Naziv));
                }

                s.Close();
            }
            catch (Exception ec)

            {
                //handle exceptions
            }

            return bolesti;

        }

        public static void DodajBolest(BolesDodaj bolest)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                //Lek l = s.Load<Lek>(idLeka);
                Bolest o = new Bolest();
                o.Naziv = bolest.Naziv;
                o.Id = bolest.Id;
                //o.Naziv = naziv;
                //o.Lekovi.Add(l);
                //l.Bolesti.Add(o);


                s.SaveOrUpdate(o);
               //s.SaveOrUpdate(l);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void DodajBolestLeku(int idBolesti,int idLeka)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Lek l = s.Load<Lek>(idLeka);


                //o.Naziv = naziv;
                Bolest o = s.Load<Bolest>(idBolesti);
                o.Lekovi.Add(l);
                l.Bolesti.Add(o);


                s.SaveOrUpdate(o);
               s.SaveOrUpdate(l);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static List<BolestView> VratiBolestLeku(int idLeka)
        {
            List<BolestView> bolesti = new List<BolestView>();
            try
            {
                ISession s = DataLayer.GetSession();
                Lek lek = s.Load<Lek>(idLeka);

                foreach (Bolest b in lek.Bolesti)
                {

                    bolesti.Add(new BolestView(b.Naziv));
                }



                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return bolesti;

        }
        public static void ObrisiBolest(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolest o = s.Load<Bolest>(id);
                foreach (Lek lek in o.Lekovi)
                {
                    lek.Bolesti.Remove(o);
                }

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void AzurirajBolest(BolesDodaj bolest)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Bolest b = new Bolest();

                Bolest o = s.Load<Bolest>(bolest.Id);

                o.Naziv = bolest.Naziv;

                s.SaveOrUpdate(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }


        #endregion
        #region Lek
        public static List<LekView> VratiSveLekove()
        {
            List<LekView> lekovi = new List<LekView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Lek> lek = from o in s.Query<Lek>()
                                       select o;

                foreach (Lek z in lek)
                {
                    lekovi.Add(new LekView(z.Id, z.DozaDeca, z.DozaOdrasli, z.DozaTrudnice, z.KomercijalniNaziv, z.HemijskiNaziv, z.Cena));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lekovi;

        }

        public static void DodajKontraindikacijeLeku(int idLeka, string kontraindikacije)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Lek l = s.Load<Lek>(idLeka);
                LekKontraindikacije i = new LekKontraindikacije();

                //o.Id = p.Id;

                i.Id.KontraindikacijeLeka = kontraindikacije;
                i.Id.LekImaKontraindikacije = l;

                s.SaveOrUpdate(i);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static List<string> VratiKontraindikacije(int idLeka)
        {
            List<string> kontraindikacije = new List<string>();
            try
            {
                ISession s = DataLayer.GetSession();

                Lek l = s.Load<Lek>(idLeka);

                

                foreach (LekKontraindikacije lk in l.KontraindikacijeLekovi)
                {
                    kontraindikacije.Add(lk.Id.KontraindikacijeLeka);
                }

                s.Close();

                
            }
            catch (Exception ec)
            {
                //handle exceptions
                //return string.Empty;
            }
            return kontraindikacije;
        }

        public static void DodajLek(int DozaDeca, int DozaOdrasli, int DozaTrudnice, string KomercijalniNaziv, string HemijskiNaziv, int Cena, string primarnaGrupa,string imeProizvodjaca)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lek o = new Lek();

                //o.Id = p.Id;
                o.KomercijalniNaziv = KomercijalniNaziv;
                o.HemijskiNaziv = HemijskiNaziv;
                o.DozaDeca = DozaDeca;
                o.DozaTrudnice = DozaTrudnice;
                o.DozaOdrasli = DozaOdrasli;
                o.Cena = Cena;
                PrimarnaGrupa prim = s.Load<PrimarnaGrupa>(primarnaGrupa);
                o.JePrimarnaGrupa = prim;
                

                Proizvođač p = (from a in s.Query<Proizvođač>()
                                where a.Naziv == imeProizvodjaca
                                select a).FirstOrDefault();
                o.ProizvodiLek = p;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void DodajSePakuje(int idLeka, string tipPakovanja, string sastav, int kolicina)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SePakuje r = new SePakuje();
                Lek l = s.Load<Lek>(idLeka);
                VrstaPakovanja vr= (from a in s.Query<VrstaPakovanja>()
                                    where a.Tip == tipPakovanja
                                    select a).FirstOrDefault();

                //r.Id = pak.Id;
                r.Id.LekSePakujeU = l;
                r.Id.SePakujeVrstaPakovanja = vr;
                r.Sastav = sastav;
                r.Količina = kolicina;

                s.Save(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static List<string> VratiNeželjeneEfekte(int idLeka)
        {
            List<string> efekti = new List<string>();
            try
            {
                ISession s = DataLayer.GetSession();

                Lek l = s.Load<Lek>(idLeka);



                foreach (LekNeželjeniEfekti lk in l.NeželjeniEfektiLekovi)
                {
                    efekti.Add(lk.Id.NeželjeniEfektiLeka);
                }

                s.Close();


            }
            catch (Exception ec)
            {
                //handle exceptions
                //return string.Empty;
            }
            return efekti;
        }


        public static void AzurirajLek(int id, string komercijalninaziv, string hemijskinaziv,
                            int dozadeca, int dozaodrasli, int dozatrudnice, int cena)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Lek o = new Lek();

                o.Id = id;
                o.KomercijalniNaziv = komercijalninaziv;
                o.HemijskiNaziv = hemijskinaziv;
                o.DozaDeca = dozadeca;
                o.DozaOdrasli = dozaodrasli;
                o.DozaTrudnice = dozatrudnice;
                o.Cena = cena;
               


                s.SaveOrUpdate(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static void DodajLekProdajnomMestu(int idL, int idP, int kol)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProdajnoMesto p = s.Load<ProdajnoMesto>(idP);
                Lek l = s.Load<Lek>(idL);
                SeNalazi novi = new SeNalazi();
                novi.Id.LekSeNalaziU = l;
                novi.Id.SeNalaziProdajnoMesto = p;
                novi.Količina = kol;


                s.SaveOrUpdate(novi);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void ObrisiLekProdajnomMestu(int idL, int idP)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SeNalazi p = (from a in s.Query<SeNalazi>()
                              where a.Id.LekSeNalaziU.Id == idL && a.Id.SeNalaziProdajnoMesto.Id==idP
                              select a).FirstOrDefault();

                s.Delete(p);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }



        public static void ObrisiLek(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lek o = s.Load<Lek>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void DodajNezeljeneEfekte(int idLeka, string efekti)
        {
            try
            {
                
                ISession s = DataLayer.GetSession();
                Lek l = s.Load<Lek>(idLeka);
                LekNeželjeniEfekti i = new LekNeželjeniEfekti();

                //o.Id = p.Id;

                i.Id.LekImaNeželjeneEfekte = l;
                i.Id.NeželjeniEfektiLeka = efekti;

                s.SaveOrUpdate(i);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }


        #endregion
    }
}
