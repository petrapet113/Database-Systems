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

namespace BazeProjekat.Forme
{
    public partial class ZaposleniForm : Form
    {
        ProdajnoMestoBasic ProdMesto;
        public void popuniPodatke()
        {

            String pom;
            listaZaposlenih.Items.Clear();
            List<ZaposleniPregled> podaci = DTOManager.VratiSveZaposlene();



            foreach (ZaposleniPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.JMBG.ToString(), p.Ime, p.Prezime, p.DatumRođenja.ToString(), p.Ulica, p.Broj.ToString(), p.Grad });
                listaZaposlenih.Items.Add(item);

            }



            listaZaposlenih.Refresh();
        }

        public ZaposleniForm()
        {
            
            InitializeComponent();
            
        }
        public ZaposleniForm(ProdajnoMestoBasic prodmesto)
        {

            InitializeComponent();
            ProdMesto = prodmesto;
        }
        private void ZaposleniForm_Load(object sender, EventArgs e)
        {
            listaZaposlenih.Items.Clear();
            List<Zaposleni> podaci = DTOManager.VratiZaposleneNaOvomProdMestu(ProdMesto); 

            foreach (Zaposleni p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.JMBG.ToString(), p.Ime, p.Prezime, p.Grad, p.Ulica, p.Broj.ToString(),p.DatumRođenja.ToString()
                });
                listaZaposlenih.Items.Add(item);
            }
            listaZaposlenih.Refresh();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listaProdajnihMesta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajZaposlenogForm forma = new DodajZaposlenogForm(ProdMesto);
            forma.ShowDialog();
            this.listaZaposlenih.Refresh();

        }

        private void buttonObrišiRadnika_Click(object sender, EventArgs e)
        {
            if (listaZaposlenih.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog koga zelite da obrisete!");
                return;
            }

            long idZaposleni = Int64.Parse(listaZaposlenih.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog zaposlenog?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiZaposlenog(idZaposleni);
                MessageBox.Show("Brisanje zaposlenog je uspesno obavljeno!");
                //DTOManager.VratiZaposleneNaOvomProdMestu(ProdMesto);
            }
            else
            {

            }

        }

        
    }
}
