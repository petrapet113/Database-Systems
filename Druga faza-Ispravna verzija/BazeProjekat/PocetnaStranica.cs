using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazeProjekat.Forme;


namespace BazeProjekat
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

        private void PocetnaStranica_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ProdajnaMesta(object sender, EventArgs e)
        {
           //ProdajnaMestaForm forma = new ProdajnaMestaForm();
            //forma.ShowDialog();
        }

        private void button2_Zaposleni(object sender, EventArgs e)
        {
            ZaposleniGlavnaForm forma = new ZaposleniGlavnaForm();
            forma.ShowDialog();
        }

        private void btn_Lekovi(object sender, EventArgs e)
        {
            LekoviGlavnaForm forma = new LekoviGlavnaForm();
            forma.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1ProdajnaMesta(object sender, EventArgs e)
        {
           

        }

        private void cmdProdajnaMesta_Click(object sender, EventArgs e)
        {
            ProdajnaMestaForm forma = new ProdajnaMestaForm();
            forma.ShowDialog();
        }

        private void PocetnaStranica_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {

        }

        private void PocetnaStranica_BackColorChanged(object sender, EventArgs e)
        {

        }
    }
}
