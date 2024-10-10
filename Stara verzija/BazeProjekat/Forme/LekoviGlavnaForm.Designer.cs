
namespace BazeProjekat.Forme
{
    partial class LekoviGlavnaForm
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
            this.button1Dodaj = new System.Windows.Forms.Button();
            this.button1Izmeni = new System.Windows.Forms.Button();
            this.button1Obriši = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewLekovi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1Dodaj
            // 
            this.button1Dodaj.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Dodaj.Location = new System.Drawing.Point(793, 35);
            this.button1Dodaj.Name = "button1Dodaj";
            this.button1Dodaj.Size = new System.Drawing.Size(158, 60);
            this.button1Dodaj.TabIndex = 0;
            this.button1Dodaj.Text = "Dodaj novi lek";
            this.button1Dodaj.UseVisualStyleBackColor = true;
            this.button1Dodaj.Click += new System.EventHandler(this.button1Dodaj_Click);
            // 
            // button1Izmeni
            // 
            this.button1Izmeni.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Izmeni.Location = new System.Drawing.Point(793, 201);
            this.button1Izmeni.Name = "button1Izmeni";
            this.button1Izmeni.Size = new System.Drawing.Size(158, 57);
            this.button1Izmeni.TabIndex = 1;
            this.button1Izmeni.Text = "Izmeni lek";
            this.button1Izmeni.UseVisualStyleBackColor = true;
            this.button1Izmeni.Click += new System.EventHandler(this.button1Izmeni_Click);
            // 
            // button1Obriši
            // 
            this.button1Obriši.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Obriši.Location = new System.Drawing.Point(793, 118);
            this.button1Obriši.Name = "button1Obriši";
            this.button1Obriši.Size = new System.Drawing.Size(158, 58);
            this.button1Obriši.TabIndex = 2;
            this.button1Obriši.Text = "Obriši lek";
            this.button1Obriši.UseVisualStyleBackColor = true;
            this.button1Obriši.Click += new System.EventHandler(this.button1Obriši_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(350, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Prikazi bolesti koju leci odabrani lek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewLekovi
            // 
            this.listViewLekovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewLekovi.HideSelection = false;
            this.listViewLekovi.Location = new System.Drawing.Point(12, 21);
            this.listViewLekovi.Name = "listViewLekovi";
            this.listViewLekovi.Size = new System.Drawing.Size(733, 305);
            this.listViewLekovi.TabIndex = 5;
            this.listViewLekovi.UseCompatibleStateImageBehavior = false;
            this.listViewLekovi.View = System.Windows.Forms.View.Details;
            this.listViewLekovi.SelectedIndexChanged += new System.EventHandler(this.listViewLekovi_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 33;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Komercijalni naziv";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hemijski naziv";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cena";
            this.columnHeader4.Width = 53;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Doza za decu";
            this.columnHeader5.Width = 94;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Doza za odrasle";
            this.columnHeader6.Width = 111;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Doza za trudnice";
            this.columnHeader7.Width = 117;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Proizvodjac";
            this.columnHeader8.Width = 82;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(46, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "Dodaj kontraindikacije leku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(46, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 60);
            this.button3.TabIndex = 7;
            this.button3.Text = "Dodaj nezeljene efekte leku";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(350, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 60);
            this.button4.TabIndex = 8;
            this.button4.Text = "Dodaj vrstu pakovanja";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // LekoviGlavnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(976, 588);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listViewLekovi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1Obriši);
            this.Controls.Add(this.button1Izmeni);
            this.Controls.Add(this.button1Dodaj);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LekoviGlavnaForm";
            this.Text = "LekoviGlavnaForm";
            this.Load += new System.EventHandler(this.LekoviForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1Dodaj;
        private System.Windows.Forms.Button button1Izmeni;
        private System.Windows.Forms.Button button1Obriši;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewLekovi;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}