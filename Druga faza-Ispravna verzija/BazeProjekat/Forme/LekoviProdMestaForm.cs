using BazeProjekat.Entiteti;
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
    public partial class LekoviProdMestaForm : Form
    {
        ProdajnoMestoBasic ProdMesto;
        public LekoviProdMestaForm()
        {
            InitializeComponent();
        }
        public LekoviProdMestaForm(ProdajnoMestoBasic prod)
        {
            InitializeComponent();
            ProdMesto = prod;
        }

        private void LekoviProdMestaForm_Load(object sender, EventArgs e)
        {
            listViewLekovi.Items.Clear();
            List<LekBasic> lekovi = DTOManager.VratiLekoveProdajnogMesta(ProdMesto);

            foreach (LekBasic le in lekovi)
            {
                ListViewItem item = new ListViewItem(new string[]
               {
                    le.Id.ToString(),le.KomercijalniNaziv,le.HemijskiNaziv,le.DozaOdrasli.ToString(),le.DozaDeca.ToString(),le.DozaTrudnice.ToString(),le.Cena.ToString(),le.Kolicina.ToString()
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
            SviLekoviForm forma = new SviLekoviForm(ProdMesto);
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SviLekoviBrisanje forma = new SviLekoviBrisanje(ProdMesto);
            forma.ShowDialog();
        }
    }
}
