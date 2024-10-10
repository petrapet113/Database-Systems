using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazeProjekat.Entiteti;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;

namespace BazeProjekat
{
    public class DTOManager
    {
        #region ProdajnoMesto
        //vrati sve prodavnice 
        //dodaj prodavnicu
        //izmeni postojecu prosledjujemo ProdMestoBasic
        //obrisi prodavnicu
        public static List<ProdajnoMestoPregled> VratiSvaProdMesta()
        {
            List<ProdajnoMestoPregled> prodajnaMesta = new List<ProdajnoMestoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProdajnoMesto> svaProdMesta = from o in s.Query<ProdajnoMesto>()
                                                          select o;

                foreach (ProdajnoMesto p in svaProdMesta)
                {
                    prodajnaMesta.Add(new ProdajnoMestoPregled(p.Id, p.Naziv, p.Ulica, p.Grad, p.Broj));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return prodajnaMesta;

        }
        public static void obrisiProdajnoMesto(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BazeProjekat.Entiteti.ProdajnoMesto o = s.Load<BazeProjekat.Entiteti.ProdajnoMesto>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void DodajProdajnoMesto(ProdajnoMestoBasic prod)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProdajnoMesto novoProdajnoMesto = new ProdajnoMesto();
                novoProdajnoMesto.Naziv = prod.Naziv;
                novoProdajnoMesto.Ulica = prod.Ulica;
                novoProdajnoMesto.Grad = prod.Grad;
                novoProdajnoMesto.Broj = prod.Broj;

                s.SaveOrUpdate(novoProdajnoMesto);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static void AzurirajProdajnoMesto(ProdajnoMestoBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProdajnoMesto o = s.Load<ProdajnoMesto>(p.Id);
                o.Naziv = p.Naziv;
                o.Grad = p.Grad;
                o.Ulica = p.Ulica;
                o.Broj = p.Broj;


                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }

        public static ProdajnoMestoBasic VratiProdajnoMesto(int id)
        {
            ProdajnoMestoBasic pm = new ProdajnoMestoBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ProdajnoMesto o = s.Load<ProdajnoMesto>(id);
                pm = new ProdajnoMestoBasic(o.Id, o.Naziv, o.Ulica, o.Grad, o.Broj);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pm;
        }
        #endregion

        #region Zaposleni
        public static void DodajZaposlenog(ZaposleniBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni o = new Zaposleni();

                o.JMBG = p.JMBG;
                o.Ime = p.Ime;
                o.Prezime = p.Prezime;
                o.DatumRođenja = p.DatumRođenja;
                o.Ulica = p.Ulica;
                o.Broj = p.Broj;
                o.Grad = p.Grad;
                ProdajnoMesto a = s.Load<ProdajnoMesto>(p.RadiUProdMesto.Id);
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

        public static void AzurirajZaposlenog(ZaposleniBasic p,string naziv)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zaposleni o = new Zaposleni();
                o.JMBG = p.JMBG;
                o.Ime = p.Ime;
                o.Prezime = p.Prezime;
                o.DatumRođenja = p.DatumRođenja;
                o.Ulica = p.Ulica;
                o.Broj = p.Broj;
                o.Grad = p.Grad;
                ProdajnoMesto a = (from l in s.Query<ProdajnoMesto>()
                                   where l.Naziv == naziv
                                   select l).FirstOrDefault();
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
        public static List<Zaposleni> VratiZaposleneNaOvomProdMestu(ProdajnoMestoBasic prod)
        {
            List<Zaposleni> zaposleni = new List<Zaposleni>();
            try
            {
                ISession s = DataLayer.GetSession();

                ProdajnoMesto p = s.Load<ProdajnoMesto>(prod.Id);

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

        public static List<ZaposleniPregled> VratiSveZaposlene()
        {
            List<ZaposleniPregled> zaposleni = new List<ZaposleniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zaposleni> sviZaposleni = from o in s.Query<Zaposleni>()
                                                      select o;

                foreach (Zaposleni z in sviZaposleni)
                {
                    zaposleni.Add(new ZaposleniPregled(z.JMBG, z.Ime, z.Prezime, z.Ulica, z.Grad, z.Broj, z.DatumRođenja,z.RadiUProdMesto.Naziv));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return zaposleni;

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

        #endregion

        #region Lek
        public static void DodajLek(LekBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lek o = new Lek();

                //o.Id = p.Id;
                o.KomercijalniNaziv = p.KomercijalniNaziv;
                o.HemijskiNaziv = p.HemijskiNaziv;
                o.DozaDeca = p.DozaDeca;
                o.DozaTrudnice = p.DozaTrudnice;
                o.DozaOdrasli = p.DozaOdrasli;
                o.Cena = p.Cena;
                o.JePrimarnaGrupa = p.JePrimarnaGrupa;
                o.ProizvodiLek = p.ProizvodiLek;

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
        public static void ObrisiLekIzProdajnogMesta(int idL, int idP)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProdajnoMesto p = s.Load<ProdajnoMesto>(idP);
                Lek l = s.Load<Lek>(idL);
                SeNalazi n = new SeNalazi();
                n = (from o in s.Query<SeNalazi>()
                      where o.Id.LekSeNalaziU.Id==idL && o.Id.SeNalaziProdajnoMesto.Id==idP
                      select o).FirstOrDefault();



                s.Delete(n);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

            public static void AzurirajLek(LekBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                int lekId = p.Id;
                Lek o = s.Load<Lek>(lekId);

                o.Id = p.Id;
                o.KomercijalniNaziv = p.KomercijalniNaziv;
                o.HemijskiNaziv = p.HemijskiNaziv;
                o.DozaDeca = p.DozaDeca;
                o.DozaOdrasli = p.DozaOdrasli;
                o.DozaTrudnice = p.DozaTrudnice;
                o.Cena = p.Cena;
                o.JePrimarnaGrupa = p.JePrimarnaGrupa;



                s.SaveOrUpdate(o);
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
        public static PrimarnaGrupa VratiPrimarnuGrupu(string naziv)
        {
            PrimarnaGrupaBasic b = new PrimarnaGrupaBasic();
            PrimarnaGrupa o = new PrimarnaGrupa();
            try
            {

                ISession s = DataLayer.GetSession();

                o = s.Load<PrimarnaGrupa>(naziv);
                b = new PrimarnaGrupaBasic(o.Naziv);
                s.Close();


            }
            catch (Exception ec)
            {
                //handle exceptions
            }


            return o;


        }
        public static VrstaPakovanja VratiVrstuPakovanja(string naziv)
        {

            VrstaPakovanja vr= new VrstaPakovanja();
            try
            {

                ISession s = DataLayer.GetSession();

                 vr = (from o in s.Query<VrstaPakovanja>()
                     where o.Tip == naziv
                     select o).FirstOrDefault();

                s.Close();


            }
            catch (Exception ec)
            {
                //handle exceptions
            }


            return vr;


        }
        public static List<LekBasic> VratiLekoveProdajnogMesta(ProdajnoMestoBasic p)
        {
            List<LekBasic> lekovi = new List<LekBasic>();
            try
            {
                ISession session = DataLayer.GetSession();


                var seNalazi = session.Query<SeNalazi>()
                    .Where(s => s.Id.SeNalaziProdajnoMesto.Id == p.Id)
                    .ToList();

                foreach (SeNalazi seNalaziItem in seNalazi)
                {
                    Lek lek = seNalaziItem.Id.LekSeNalaziU;
                    lekovi.Add(new LekBasic(lek.Id, lek.DozaDeca, lek.DozaOdrasli, lek.DozaTrudnice, lek.KomercijalniNaziv, lek.HemijskiNaziv, lek.Cena,seNalaziItem.Količina));
                }

                session.Close();
            }
            catch (Exception ex)
            {
                // handle exceptions
            }

            return lekovi;
        }
        public static List<LekPregled> VratiSveLekove()
        {
            List<LekPregled> lekovi = new List<LekPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Lek> lek = from o in s.Query<Lek>()
                                       select o;

                foreach (Lek z in lek)
                {
                    lekovi.Add(new LekPregled(z.Id, z.DozaDeca, z.DozaOdrasli, z.DozaTrudnice, z.KomercijalniNaziv, z.HemijskiNaziv, z.Cena,z.ProizvodiLek.Naziv));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lekovi;

        }

        public static LekBasic VratiLek(int id)
        {
            LekBasic pm = new LekBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Lek o = s.Load<Lek>(id);
                pm = new LekBasic(o.Id, o.DozaDeca, o.DozaOdrasli, o.DozaTrudnice, o.KomercijalniNaziv, o.HemijskiNaziv, o.Cena);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pm;
        }
        public static Lek VratiObicanLek(int id)
        {
            Lek pm = new Lek();
            try
            {
                ISession s = DataLayer.GetSession();

                pm= s.Load<Lek>(id);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pm;
        }

        public static void DodajKontraindikacijuLeku(KontraindikacijeBasic k)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                LekKontraindikacije i = new LekKontraindikacije();

                //o.Id = p.Id;

                i.Id.KontraindikacijeLeka = k.Id.KontraindikacijeLeka;
                i.Id.LekImaKontraindikacije = k.Id.LekImaKontraindikacije;

                s.SaveOrUpdate(i);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }

        public static void DodajNezeljeniEfakatLeku(NezeljeniEfektiBasic n)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                LekNeželjeniEfekti i = new LekNeželjeniEfekti();

                //o.Id = p.Id;

                i.Id.LekImaNeželjeneEfekte = n.Id.LekImaNeželjeneEfekte;
                i.Id.NeželjeniEfektiLeka = n.Id.NeželjeniEfektiLeka;

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
        #region Bolest
        public static void DodajBolest(BolestBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bolest o = new Bolest();
                o.Naziv = p.Naziv;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static List<BolestPregled> VratiBolestLeku(int idLeka)
        {
            List<BolestPregled> bolesti = new List<BolestPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                Lek lek = s.Load<Lek>(idLeka);

                foreach (Bolest b in lek.Bolesti)
                {

                    bolesti.Add(new BolestPregled(b.Naziv));
                }



                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return bolesti;

        }

        #endregion

        #region Recept
        public static List<ReceptBasic> VratiRecepteProdajnogMesta(ProdajnoMestoBasic p)
        {
            List<ReceptBasic> recepti = new List<ReceptBasic>();
            try
            {
                ISession session = DataLayer.GetSession();


                ProdajnoMesto prodajnoMesto = session.Get<ProdajnoMesto>(p.Id);

                foreach (Recept r in prodajnoMesto.Recepti)
                {
                    recepti.Add(new ReceptBasic(r.SerijskiBroj,r.IzdajeRecept.Ime,r.FarmaceutRealizuje.Ime,r.IzdajeRecept.Prezime,r.FarmaceutRealizuje.Prezime));
                }

                session.Close();
            }
            catch (Exception ex)
            {
                // handle exceptions
            }

            return recepti;
        }
        public static void DodajSePakuje(SePakuje pak)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SePakuje r = new SePakuje();

                r.Id = pak.Id;
                r.Sastav = pak.Sastav;
                r.Količina = pak.Količina;

                s.Save(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        #endregion
        #region Proizvodjac
        public static Proizvođač VratiProizvodjaca(string naziv)
        {

            Proizvođač pr = new Proizvođač();
            try
            {

                ISession s = DataLayer.GetSession();

                pr = (from o in s.Query<Proizvođač>()
                      where o.Naziv == naziv
                      select o).FirstOrDefault();

                s.Close();


            }
            catch (Exception ec)
            {
                //handle exceptions
            }


            return pr;


        }
        #endregion

    }
}
