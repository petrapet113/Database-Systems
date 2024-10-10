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
    public partial class BolestiForm : Form
    {
        LekBasic lek;
        public BolestiForm()
        {
            InitializeComponent();
        }
        public BolestiForm(LekBasic l)
        {
            InitializeComponent();
            lek = l;
        }

        private void BolestiForm_Load(object sender, EventArgs e)
        {
            List<BolestPregled> bolesti = DTOManager.VratiBolestLeku(lek.Id);
            listView1.Items.Clear();
            foreach (BolestPregled b in bolesti)
            {
                ListViewItem item = new ListViewItem(new string[]
                { b.Naziv
                });
                listView1.Items.Add(item);

            }
            listView1.Refresh();
        }

        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
