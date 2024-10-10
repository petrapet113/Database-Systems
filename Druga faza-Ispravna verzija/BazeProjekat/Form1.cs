using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazeProjekat.Entiteti;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;

namespace BazeProjekat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdUcitavanjeProdMesta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                BazeProjekat.Entiteti.ProdajnoMesto p = s.Load<BazeProjekat.Entiteti.ProdajnoMesto>(2);

                MessageBox.Show(p.Naziv);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                long broj = 2906999726059;

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Zaposleni p = s.Load<Zaposleni>(broj);

                MessageBox.Show(p.Ime);
                MessageBox.Show(p.RadiUProdMesto.Naziv);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                //Ucitavaju se podaci o prodavnici za zadatim brojem
                ProdajnoMesto p = s.Load<ProdajnoMesto>(12);

                MessageBox.Show(p.Naziv);
                foreach (Recept r in p.Recepti)
                {
                    MessageBox.Show(r.SerijskiBroj + " ");
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void ReceptLekar_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Recept p = s.Load<Recept>(41);


                MessageBox.Show(p.IzdajeRecept.Prezime);

                s.Close();
            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message);
            }
        }

        private void PrimarnaGrupaLeka_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                //Ucitavaju se podaci o prodavnici za zadatim brojem
                PrimarnaGrupa p = s.Load<PrimarnaGrupa>("antibiotik");


                foreach (Lek l  in p.Lekovi)
                {
                    MessageBox.Show(l.HemijskiNaziv );
                }

                s.Close();
            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message);
            }

        }

        private void LekoviProizvodjaca_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Proizvođač p = s.Load<Proizvođač>(2);


                foreach (Lek l in p.Lekovi)
                {
                    MessageBox.Show(l.KomercijalniNaziv);
                }

                s.Close();
            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message);
            }
        }

        private void SadrziVrstu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lek r1 = s.Load<Lek>(3);

                foreach (Bolest v11 in r1.Bolesti)
                {
                    MessageBox.Show(v11.Naziv);
                }


                Bolest v2 = s.Load<Bolest>(1);

                foreach (Lek r2 in v2.Lekovi)
                {
                    MessageBox.Show(r2.KomercijalniNaziv);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PrimarnaGrupa r1 = s.Load<PrimarnaGrupa>("analgetik");

                foreach (Recept v11 in r1.Recepti)
                {
                    MessageBox.Show(v11.SerijskiBroj + "");
                }


                Recept v2 = s.Load<Recept>(41);

                foreach (PrimarnaGrupa r2 in v2.PrimarneGrupe)
                {
                    MessageBox.Show(r2.Naziv);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VrstaPakovanja r1 = s.Load<VrstaPakovanja>(1);

                foreach (Recept v11 in r1.Recepti)
                {
                    MessageBox.Show(v11.SerijskiBroj + "");
                }


                Recept v2 = s.Load<Recept>(41);

                foreach (VrstaPakovanja r2 in v2.VrstePakovanja)
                {
                    MessageBox.Show(r2.Tip);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProdajnoMesto p1 = s.Load<ProdajnoMesto>(4);

                Lek l1 = s.Load<Lek>(2);
                SeNalazi se = new SeNalazi();
                se.Id.LekSeNalaziU = l1;
                se.Id.SeNalaziProdajnoMesto = p1;
                se.Količina = 100;

                
                s.Save(se);
                s.Flush();

  

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VrstaPakovanja v1 = s.Load<VrstaPakovanja>(4);

                Lek l1 = s.Load<Lek>(2);
                SePakuje se = new SePakuje();
                se.Id.LekSePakujeU = l1;
                se.Id.SePakujeVrstaPakovanja = v1;
                se.Količina = 100;
                se.Sastav = "paracetamol, celuloza, stearinska kiselina";


                s.Save(se);
                MessageBox.Show("Dodali smo " + se.Sastav);
                s.Flush();



                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
