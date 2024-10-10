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
    public partial class ProdajnaMestaForm : Form
    {
        public ProdajnaMestaForm()
        {
            InitializeComponent();
        }
      
        public void popuniPodatke()
        {
            listaProdajnihMesta.Items.Clear();
            List<ProdajnoMestoPregled> podaci = DTOManager.VratiSvaProdMesta();

            foreach(ProdajnoMestoPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.Id.ToString(), p.Naziv, p.Ulica, p.Broj.ToString(), p.Grad
                });
                listaProdajnihMesta.Items.Add(item);
            }
            listaProdajnihMesta.Refresh();
            
        }

        private void cmdObrisiProdMesto(object sender, EventArgs e)
        {
            //this.popuniPodatke();
            if (listaProdajnihMesta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite radnika koga zelite da obrisete!");
                return;
            }

            int idProd = Int32.Parse(listaProdajnihMesta.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani proizvod?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                DTOManager.obrisiProdajnoMesto(idProd);
                MessageBox.Show("Brisanje prodavnice je uspesno obavljeno!");
                this.popuniPodatke();
            }
            else
            {

            }

        }

        private void cmdDodajProdMesto(object sender, EventArgs e)
        {
            DodajProdajnoMestoForm forma = new DodajProdajnoMestoForm();
            forma.ShowDialog();
            
        }

        private void cmdIzmeniProdajnoMesto(object sender, EventArgs e)
        {
            IzmeniProdajnoMestoForm forma = new IzmeniProdajnoMestoForm();
            forma.ShowDialog();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Zaposleni(object sender, EventArgs e)
        {
            if (listaProdajnihMesta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodajno mesto kome zelite da dodate zaposlenog!");
                return;
            }

            int idProdavnice = Int32.Parse(listaProdajnihMesta.SelectedItems[0].SubItems[0].Text);
            ProdajnoMestoBasic p = DTOManager.VratiProdajnoMesto(idProdavnice);

            ZaposleniForm forma = new ZaposleniForm(p);
            forma.ShowDialog();
        }

        private void button4_Lekovi(object sender, EventArgs e)
        {
            if (listaProdajnihMesta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodajno mesto za koje zelite da prikazete lekove");
                return;
            }

            int idProdavnice = Int32.Parse(listaProdajnihMesta.SelectedItems[0].SubItems[0].Text);
            ProdajnoMestoBasic p = DTOManager.VratiProdajnoMesto(idProdavnice);
            LekoviProdMestaForm forma = new LekoviProdMestaForm(p);
            forma.ShowDialog();
        }

        private void cmdVratiProdMesta_Click(object sender, EventArgs e)
        {
            popuniPodatke();

        }

        private void ProdajnaMestaForm_Load(object sender, EventArgs e)
        {
            popuniPodatke();
        }

        private void groupBox1ProdM_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listaProdajnihMesta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodajno mesto za koje zelite da prikazete recepte");
                return;
            }

            int idProdavnice = Int32.Parse(listaProdajnihMesta.SelectedItems[0].SubItems[0].Text);
            ProdajnoMestoBasic p = DTOManager.VratiProdajnoMesto(idProdavnice);
            ReceptiNovaForm forma = new ReceptiNovaForm(p);
            forma.ShowDialog();
        }
    }
}
