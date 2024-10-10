
namespace BazeProjekat.Forme
{
    partial class ZaposleniGlavnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaZaposlenih = new System.Windows.Forms.ListView();
            this.JMBG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ulica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Broj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumRođenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBrojZaposlenih = new System.Windows.Forms.TextBox();
            this.buttonIzmeniRadnika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaZaposlenih
            // 
            this.listaZaposlenih.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.JMBG,
            this.Ime,
            this.Prezime,
            this.Grad,
            this.Ulica,
            this.Broj,
            this.DatumRođenja,
            this.columnHeader1});
            this.listaZaposlenih.HideSelection = false;
            this.listaZaposlenih.Location = new System.Drawing.Point(21, 27);
            this.listaZaposlenih.Name = "listaZaposlenih";
            this.listaZaposlenih.Size = new System.Drawing.Size(581, 265);
            this.listaZaposlenih.TabIndex = 2;
            this.listaZaposlenih.UseCompatibleStateImageBehavior = false;
            this.listaZaposlenih.View = System.Windows.Forms.View.Details;
            this.listaZaposlenih.SelectedIndexChanged += new System.EventHandler(this.listaZaposlenih_SelectedIndexChanged);
            // 
            // JMBG
            // 
            this.JMBG.Text = "JMBG";
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 43;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 71;
            // 
            // Grad
            // 
            this.Grad.Text = "Grad";
            // 
            // Ulica
            // 
            this.Ulica.Text = "Ulica";
            // 
            // Broj
            // 
            this.Broj.Text = "Broj";
            // 
            // DatumRođenja
            // 
            this.DatumRođenja.Text = "Datum rođenja";
            this.DatumRođenja.Width = 112;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Radno mesto";
            this.columnHeader1.Width = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ukupan broj zaposlenih:";
            // 
            // textBoxBrojZaposlenih
            // 
            this.textBoxBrojZaposlenih.BackColor = System.Drawing.Color.White;
            this.textBoxBrojZaposlenih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrojZaposlenih.Location = new System.Drawing.Point(258, 318);
            this.textBoxBrojZaposlenih.Name = "textBoxBrojZaposlenih";
            this.textBoxBrojZaposlenih.Size = new System.Drawing.Size(154, 27);
            this.textBoxBrojZaposlenih.TabIndex = 4;
            // 
            // buttonIzmeniRadnika
            // 
            this.buttonIzmeniRadnika.BackColor = System.Drawing.Color.Silver;
            this.buttonIzmeniRadnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzmeniRadnika.Location = new System.Drawing.Point(461, 308);
            this.buttonIzmeniRadnika.Name = "buttonIzmeniRadnika";
            this.buttonIzmeniRadnika.Size = new System.Drawing.Size(127, 47);
            this.buttonIzmeniRadnika.TabIndex = 5;
            this.buttonIzmeniRadnika.Text = "Izmeni radnika";
            this.buttonIzmeniRadnika.UseVisualStyleBackColor = false;
            this.buttonIzmeniRadnika.Click += new System.EventHandler(this.buttonIzmeniRadnika_Click);
            // 
            // ZaposleniGlavnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.buttonIzmeniRadnika);
            this.Controls.Add(this.textBoxBrojZaposlenih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaZaposlenih);
            this.Name = "ZaposleniGlavnaForm";
            this.Text = "ZaposleniGlavnaForm";
            this.Load += new System.EventHandler(this.ZaposleniGlavnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaZaposlenih;
        private System.Windows.Forms.ColumnHeader JMBG;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Grad;
        private System.Windows.Forms.ColumnHeader Ulica;
        private System.Windows.Forms.ColumnHeader Broj;
        private System.Windows.Forms.ColumnHeader DatumRođenja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBrojZaposlenih;
        private System.Windows.Forms.Button buttonIzmeniRadnika;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}