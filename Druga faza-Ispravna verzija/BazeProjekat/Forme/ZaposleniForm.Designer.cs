
namespace BazeProjekat.Forme
{
    partial class ZaposleniForm
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
            this.buttonDodajRadnika = new System.Windows.Forms.Button();
            this.buttonObrišiRadnika = new System.Windows.Forms.Button();
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
            this.DatumRođenja});
            this.listaZaposlenih.HideSelection = false;
            this.listaZaposlenih.Location = new System.Drawing.Point(23, 26);
            this.listaZaposlenih.Name = "listaZaposlenih";
            this.listaZaposlenih.Size = new System.Drawing.Size(500, 341);
            this.listaZaposlenih.TabIndex = 1;
            this.listaZaposlenih.UseCompatibleStateImageBehavior = false;
            this.listaZaposlenih.View = System.Windows.Forms.View.Details;
            this.listaZaposlenih.SelectedIndexChanged += new System.EventHandler(this.listaProdajnihMesta_SelectedIndexChanged);
            // 
            // JMBG
            // 
            this.JMBG.Text = "JMBG";
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
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
            this.DatumRođenja.Width = 114;
            // 
            // buttonDodajRadnika
            // 
            this.buttonDodajRadnika.BackColor = System.Drawing.Color.Silver;
            this.buttonDodajRadnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajRadnika.Location = new System.Drawing.Point(572, 89);
            this.buttonDodajRadnika.Name = "buttonDodajRadnika";
            this.buttonDodajRadnika.Size = new System.Drawing.Size(158, 68);
            this.buttonDodajRadnika.TabIndex = 2;
            this.buttonDodajRadnika.Text = "Dodaj Radnika";
            this.buttonDodajRadnika.UseVisualStyleBackColor = false;
            this.buttonDodajRadnika.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonObrišiRadnika
            // 
            this.buttonObrišiRadnika.BackColor = System.Drawing.Color.Silver;
            this.buttonObrišiRadnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrišiRadnika.Location = new System.Drawing.Point(572, 177);
            this.buttonObrišiRadnika.Name = "buttonObrišiRadnika";
            this.buttonObrišiRadnika.Size = new System.Drawing.Size(158, 68);
            this.buttonObrišiRadnika.TabIndex = 4;
            this.buttonObrišiRadnika.Text = "Obriši radnika";
            this.buttonObrišiRadnika.UseVisualStyleBackColor = false;
            this.buttonObrišiRadnika.Click += new System.EventHandler(this.buttonObrišiRadnika_Click);
            // 
            // ZaposleniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonObrišiRadnika);
            this.Controls.Add(this.buttonDodajRadnika);
            this.Controls.Add(this.listaZaposlenih);
            this.Name = "ZaposleniForm";
            this.Text = "ZaposleniForm";
            this.Load += new System.EventHandler(this.ZaposleniForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaZaposlenih;
        private System.Windows.Forms.ColumnHeader JMBG;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader DatumRođenja;
        private System.Windows.Forms.ColumnHeader Ulica;
        private System.Windows.Forms.ColumnHeader Grad;
        private System.Windows.Forms.ColumnHeader Broj;
        private System.Windows.Forms.Button buttonDodajRadnika;
        private System.Windows.Forms.Button buttonObrišiRadnika;
    }
}