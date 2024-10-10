
using System;

namespace BazeProjekat.Forme
{
    partial class ProdajnaMestaForm
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

        internal new void ShowDialo()
        {
            throw new NotImplementedException();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaProdajnihMesta = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ulica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1ProdM = new System.Windows.Forms.GroupBox();
            this.cmdVratiProdMesta = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmdDodajProdM = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1ProdM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaProdajnihMesta
            // 
            this.listaProdajnihMesta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Naziv,
            this.Ulica,
            this.columnHeader1,
            this.columnHeader2});
            this.listaProdajnihMesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaProdajnihMesta.HideSelection = false;
            this.listaProdajnihMesta.Location = new System.Drawing.Point(33, 28);
            this.listaProdajnihMesta.Name = "listaProdajnihMesta";
            this.listaProdajnihMesta.Size = new System.Drawing.Size(354, 315);
            this.listaProdajnihMesta.TabIndex = 0;
            this.listaProdajnihMesta.UseCompatibleStateImageBehavior = false;
            this.listaProdajnihMesta.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            // 
            // Ulica
            // 
            this.Ulica.Text = "Ulica";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Broj";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Grad";
            // 
            // groupBox1ProdM
            // 
            this.groupBox1ProdM.Controls.Add(this.cmdVratiProdMesta);
            this.groupBox1ProdM.Controls.Add(this.button3);
            this.groupBox1ProdM.Controls.Add(this.button2);
            this.groupBox1ProdM.Controls.Add(this.cmdDodajProdM);
            this.groupBox1ProdM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1ProdM.Location = new System.Drawing.Point(488, 28);
            this.groupBox1ProdM.Name = "groupBox1ProdM";
            this.groupBox1ProdM.Size = new System.Drawing.Size(253, 241);
            this.groupBox1ProdM.TabIndex = 1;
            this.groupBox1ProdM.TabStop = false;
            this.groupBox1ProdM.Text = "Podaci o prodajnom mestu";
            this.groupBox1ProdM.Enter += new System.EventHandler(this.groupBox1ProdM_Enter);
            // 
            // cmdVratiProdMesta
            // 
            this.cmdVratiProdMesta.Location = new System.Drawing.Point(-1, 51);
            this.cmdVratiProdMesta.Name = "cmdVratiProdMesta";
            this.cmdVratiProdMesta.Size = new System.Drawing.Size(252, 40);
            this.cmdVratiProdMesta.TabIndex = 3;
            this.cmdVratiProdMesta.Text = "Vrati prodajna mesta";
            this.cmdVratiProdMesta.UseVisualStyleBackColor = true;
            this.cmdVratiProdMesta.Click += new System.EventHandler(this.cmdVratiProdMesta_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-1, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Izmeni prodajno mesto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.cmdIzmeniProdajnoMesto);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Obrisi prodajno mesto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cmdObrisiProdMesto);
            // 
            // cmdDodajProdM
            // 
            this.cmdDodajProdM.Location = new System.Drawing.Point(0, 97);
            this.cmdDodajProdM.Name = "cmdDodajProdM";
            this.cmdDodajProdM.Size = new System.Drawing.Size(251, 46);
            this.cmdDodajProdM.TabIndex = 0;
            this.cmdDodajProdM.Text = "Dodaj prodajno mesto";
            this.cmdDodajProdM.UseVisualStyleBackColor = true;
            this.cmdDodajProdM.Click += new System.EventHandler(this.cmdDodajProdMesto);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(488, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zaposleni";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zaposleni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Zaposleni);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(332, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 105);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lekovi";
            this.groupBox2.Enter += new System.EventHandler(this.cmdIzmeniProdajnoMesto);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(-10, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(262, 39);
            this.button4.TabIndex = 0;
            this.button4.Text = "Lekovi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Lekovi);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(33, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 105);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recepti";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(253, 35);
            this.button5.TabIndex = 0;
            this.button5.Text = "Recepti";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ProdajnaMestaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 535);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox1ProdM);
            this.Controls.Add(this.listaProdajnihMesta);
            this.Name = "ProdajnaMestaForm";
            this.Text = "ProdajnaMestaForm";
            this.Load += new System.EventHandler(this.ProdajnaMestaForm_Load);
            this.groupBox1ProdM.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaProdajnihMesta;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Ulica;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1ProdM;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdDodajProdM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button cmdVratiProdMesta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
    }
}