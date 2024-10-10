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
    public partial class ZaposleniGlavnaForm : Form
    {
        public ZaposleniGlavnaForm()
        {
            InitializeComponent();
        }
        public void popuniPodacima()
        {
            int brojZaposlenih = 0;

            List<ZaposleniPregled> listaZaposlenih = DTOManager.VratiSveZaposlene();
            this.listaZaposlenih.Items.Clear();

            foreach (ZaposleniPregled p in listaZaposlenih)
            {
                
                ListViewItem item = new ListViewItem(new string[] { p.JMBG.ToString(), p.Ime, p.Prezime, p.DatumRođenja.ToString(), p.Ulica, p.Broj.ToString(), p.Grad,p.RadnoMesto });
                this.listaZaposlenih.Items.Add(item);
                brojZaposlenih++;
            }

            textBoxBrojZaposlenih.Text = brojZaposlenih.ToString();
            this.listaZaposlenih.Refresh();
        }
        private void ZaposleniGlavnaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void buttonIzmeniRadnika_Click(object sender, EventArgs e)
        {
            IzmeniZaposlenogForm forma = new IzmeniZaposlenogForm();
            forma.ShowDialog();
        }

        private void listaZaposlenih_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
