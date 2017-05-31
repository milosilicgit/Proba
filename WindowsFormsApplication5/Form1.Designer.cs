namespace WindowsFormsApplication5
{
    partial class Form1
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
            this.lvGrupa = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBrojGrupa = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmena = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvGrupa
            // 
            this.lvGrupa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvGrupa.FullRowSelect = true;
            this.lvGrupa.Location = new System.Drawing.Point(34, 78);
            this.lvGrupa.Name = "lvGrupa";
            this.lvGrupa.Size = new System.Drawing.Size(484, 183);
            this.lvGrupa.TabIndex = 10;
            this.lvGrupa.UseCompatibleStateImageBehavior = false;
            this.lvGrupa.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "GrupaID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sifra";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Naziv";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Opis";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Aktivno";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TipGrupe";
            // 
            // lblBrojGrupa
            // 
            this.lblBrojGrupa.AutoSize = true;
            this.lblBrojGrupa.Location = new System.Drawing.Point(35, 278);
            this.lblBrojGrupa.Name = "lblBrojGrupa";
            this.lblBrojGrupa.Size = new System.Drawing.Size(90, 17);
            this.lblBrojGrupa.TabIndex = 14;
            this.lblBrojGrupa.Text = "Broj grupa: 0";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(443, 12);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 32);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnIzmena
            // 
            this.btnIzmena.Location = new System.Drawing.Point(227, 12);
            this.btnIzmena.Name = "btnIzmena";
            this.btnIzmena.Size = new System.Drawing.Size(75, 32);
            this.btnIzmena.TabIndex = 12;
            this.btnIzmena.Text = "Izmena";
            this.btnIzmena.UseVisualStyleBackColor = true;
            this.btnIzmena.Click += new System.EventHandler(this.btnIzmena_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(35, 13);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 31);
            this.btnUnos.TabIndex = 11;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 306);
            this.Controls.Add(this.lvGrupa);
            this.Controls.Add(this.lblBrojGrupa);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmena);
            this.Controls.Add(this.btnUnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvGrupa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblBrojGrupa;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmena;
        private System.Windows.Forms.Button btnUnos;
    }
}

