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
    public partial class VrstaPakovanjaPravaForm : Form
    {
        int idLeka;
        public VrstaPakovanjaPravaForm(int id)
        {
            InitializeComponent();
            idLeka = id;
        }

        private void VrstaPakovanjaPravaForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<CheckBox> checkBoxList = new List<CheckBox>();
            checkBoxList.Add(checkBox1);
            checkBoxList.Add(checkBox2);
            checkBoxList.Add(checkBox3);
            checkBoxList.Add(checkBox4);
            string tekst = "";
            VrstaPakovanja vrsta = new VrstaPakovanja();

            foreach (CheckBox checkBox in checkBoxList)
            {
                if (checkBox.Checked)
                {
                    tekst = checkBox.Text;
                    break;
                }
            }

            if (!string.IsNullOrEmpty(tekst))
            {
                vrsta = DTOManager.VratiVrstuPakovanja(tekst);

            }



            SePakuje pakovanje = new SePakuje();
            Lek l = new Lek();
             l = DTOManager.VratiObicanLek(idLeka);

            pakovanje.Količina = (int)numericUpDown1.Value;
            pakovanje.Sastav = textBoxSastav.Text;
            pakovanje.Id.LekSePakujeU = l;
            pakovanje.Id.SePakujeVrstaPakovanja = vrsta;
            DTOManager.DodajSePakuje(pakovanje);
        }
    }
}
