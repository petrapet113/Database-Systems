
namespace BazeProjekat.Forme
{
    partial class LekoviProdMestaForm
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
            this.listViewLekovi = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Komercijalni_naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hemijski_naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DozaZaOdrasle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DozaZaDecu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DozaZaTrudnice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewLekovi
            // 
            this.listViewLekovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Komercijalni_naziv,
            this.Hemijski_naziv,
            this.DozaZaOdrasle,
            this.DozaZaDecu,
            this.DozaZaTrudnice,
            this.Cena,
            this.columnHeader1});
            this.listViewLekovi.HideSelection = false;
            this.listViewLekovi.Location = new System.Drawing.Point(37, 43);
            this.listViewLekovi.Name = "listViewLekovi";
            this.listViewLekovi.Size = new System.Drawing.Size(724, 319);
            this.listViewLekovi.TabIndex = 0;
            this.listViewLekovi.UseCompatibleStateImageBehavior = false;
            this.listViewLekovi.View = System.Windows.Forms.View.Details;
            this.listViewLekovi.SelectedIndexChanged += new System.EventHandler(this.listViewLekovi_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 40;
            // 
            // Komercijalni_naziv
            // 
            this.Komercijalni_naziv.Text = "Komercijalni naziv";
            this.Komercijalni_naziv.Width = 122;
            // 
            // Hemijski_naziv
            // 
            this.Hemijski_naziv.Text = "Hemijski naziv";
            this.Hemijski_naziv.Width = 105;
            // 
            // DozaZaOdrasle
            // 
            this.DozaZaOdrasle.Text = "DozaZaOdrasle";
            this.DozaZaOdrasle.Width = 114;
            // 
            // DozaZaDecu
            // 
            this.DozaZaDecu.Text = "DozaZaDecu";
            this.DozaZaDecu.Width = 94;
            // 
            // DozaZaTrudnice
            // 
            this.DozaZaTrudnice.Text = "DozaZaTrudnice";
            this.DozaZaTrudnice.Width = 120;
            // 
            // Cena
            // 
            this.Cena.Text = "Cena";
            this.Cena.Width = 55;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kolicina";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(178, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj lek";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(420, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Obrisi lek";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LekoviProdMestaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewLekovi);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "LekoviProdMestaForm";
            this.Text = "LekoviProdMestaForm";
            this.Load += new System.EventHandler(this.LekoviProdMestaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewLekovi;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Komercijalni_naziv;
        private System.Windows.Forms.ColumnHeader Hemijski_naziv;
        private System.Windows.Forms.ColumnHeader DozaZaOdrasle;
        private System.Windows.Forms.ColumnHeader DozaZaDecu;
        private System.Windows.Forms.ColumnHeader DozaZaTrudnice;
        private System.Windows.Forms.ColumnHeader Cena;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}