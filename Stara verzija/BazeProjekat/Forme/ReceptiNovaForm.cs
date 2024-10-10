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
    public partial class ReceptiNovaForm : Form
    {
        ProdajnoMestoBasic p;
        public ReceptiNovaForm()
        {
            InitializeComponent();
        }
        public ReceptiNovaForm(ProdajnoMestoBasic pr)
        {
            InitializeComponent();
            p = pr;
        }
        public void popuniPodatke()
        {
            listView1.Items.Clear();
            List<ReceptBasic> podaci = DTOManager.VratiRecepteProdajnogMesta(p);

            foreach (ReceptBasic z in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                   z.SerijskiBroj.ToString(),z.ImeLekara,z.PrezimeLekara,z.ImeFarmaceuta,z.PrezimeFarmaceuta
                });
                listView1.Items.Add(item);
            }
            listView1.Refresh();

        }

        private void ReceptiNovaForm_Load(object sender, EventArgs e)
        {
            popuniPodatke();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
