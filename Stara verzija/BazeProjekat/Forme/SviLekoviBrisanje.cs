using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazeProjekat.Forme
{
    public partial class SviLekoviBrisanje : Form
    {
        ProdajnoMestoBasic prod;
        public SviLekoviBrisanje()
        {
            InitializeComponent();
        }
        public SviLekoviBrisanje(ProdajnoMestoBasic p)
        {
            InitializeComponent();
            prod = p;
        }
        public void popuniPodatke()
        {
            listViewLekovi.Items.Clear();
            List<LekPregled> podaci = DTOManager.VratiSveLekove();

            foreach (LekPregled z in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    z.Id.ToString(),z.KomercijalniNaziv,z.HemijskiNaziv,z.Cena.ToString(),z.DozaDeca.ToString(),z.DozaOdrasli.ToString(),z.DozaTrudnice.ToString()
                });
                listViewLekovi.Items.Add(item);
            }
            listViewLekovi.Refresh();

        }

        private void SviLekoviBrisanje_Load(object sender, EventArgs e)
        {
            popuniPodatke();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da obrisete lek?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                LekBasic lek = new LekBasic();

                int idLeka = Int32.Parse(listViewLekovi.SelectedItems[0].SubItems[0].Text);
                

                DTOManager.ObrisiLekIzProdajnogMesta(idLeka, prod.Id);

                MessageBox.Show("Uspesno ste obrisali lek");
                this.Close();
            }
            else
            {

            }

            this.Close();
        }
    }
}
