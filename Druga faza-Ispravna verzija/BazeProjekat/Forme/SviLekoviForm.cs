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
    public partial class SviLekoviForm : Form
    {
        ProdajnoMestoBasic ProdMesto;
        public SviLekoviForm()
        {
            InitializeComponent();
        }
        public SviLekoviForm(ProdajnoMestoBasic p)
        {
            InitializeComponent();
            ProdMesto = p;
        }
        public void popuniPodatke()
        {
            listViewLekovi.Items.Clear();
            List<LekPregled> podaci = DTOManager.VratiSveLekove();

            foreach (LekPregled z in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    z.Id.ToString(),z.KomercijalniNaziv,z.HemijskiNaziv,z.Cena.ToString(),z.DozaDeca.ToString(),z.DozaOdrasli.ToString(),z.DozaTrudnice.ToString(),
                });
                listViewLekovi.Items.Add(item);
            }
            listViewLekovi.Refresh();

        }
        private void listViewLekovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi lek?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                LekBasic lek = new LekBasic();

                int idLeka = Int32.Parse(listViewLekovi.SelectedItems[0].SubItems[0].Text);
                int kolicina = (int)numericUpDownKolicina.Value;
               
                DTOManager.DodajLekProdajnomMestu(idLeka,ProdMesto.Id,kolicina);

                MessageBox.Show("Uspesno ste dodali novi lek!");
                this.Close();
            }
            else
            {

            }

            this.Close();

        }

        private void SviLekoviForm_Load(object sender, EventArgs e)
        {
            popuniPodatke();
        }
    }
}
