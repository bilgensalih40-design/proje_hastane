namespace proje_hastane
{
    partial class frmDoktorlarPaneli
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BUTTONEKLE = new System.Windows.Forms.Button();
            this.btnSİL = new System.Windows.Forms.Button();
            this.btnGÜncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "BRANŞ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(65, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "ŞİFRE:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(125, 43);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(260, 22);
            this.txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(125, 106);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(260, 22);
            this.txtSoyad.TabIndex = 6;
            this.txtSoyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(125, 169);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(260, 24);
            this.cmbBrans.TabIndex = 7;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(125, 299);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(260, 22);
            this.txtSifre.TabIndex = 9;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(125, 238);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(260, 22);
            this.mskTc.TabIndex = 10;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(963, 427);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BUTTONEKLE
            // 
            this.BUTTONEKLE.BackColor = System.Drawing.Color.RoyalBlue;
            this.BUTTONEKLE.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BUTTONEKLE.Location = new System.Drawing.Point(143, 341);
            this.BUTTONEKLE.Name = "BUTTONEKLE";
            this.BUTTONEKLE.Size = new System.Drawing.Size(97, 36);
            this.BUTTONEKLE.TabIndex = 12;
            this.BUTTONEKLE.Text = "EKLE";
            this.BUTTONEKLE.UseVisualStyleBackColor = false;
            this.BUTTONEKLE.Click += new System.EventHandler(this.BUTTONEKLE_Click);
            // 
            // btnSİL
            // 
            this.btnSİL.BackColor = System.Drawing.Color.Crimson;
            this.btnSİL.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSİL.Location = new System.Drawing.Point(256, 341);
            this.btnSİL.Name = "btnSİL";
            this.btnSİL.Size = new System.Drawing.Size(83, 36);
            this.btnSİL.TabIndex = 13;
            this.btnSİL.Text = "SİL";
            this.btnSİL.UseVisualStyleBackColor = false;
            this.btnSİL.Click += new System.EventHandler(this.btnSİL_Click);
            // 
            // btnGÜncelle
            // 
            this.btnGÜncelle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnGÜncelle.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGÜncelle.Location = new System.Drawing.Point(125, 394);
            this.btnGÜncelle.Name = "btnGÜncelle";
            this.btnGÜncelle.Size = new System.Drawing.Size(236, 39);
            this.btnGÜncelle.TabIndex = 14;
            this.btnGÜncelle.Text = "GÜNCELLE";
            this.btnGÜncelle.UseVisualStyleBackColor = false;
            this.btnGÜncelle.Click += new System.EventHandler(this.btnGÜncelle_Click);
            // 
            // frmDoktorlarPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1391, 445);
            this.Controls.Add(this.btnGÜncelle);
            this.Controls.Add(this.btnSİL);
            this.Controls.Add(this.BUTTONEKLE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoktorlarPaneli";
            this.Text = "frmDoktorlarPaneli";
            this.Load += new System.EventHandler(this.frmDoktorlarPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BUTTONEKLE;
        private System.Windows.Forms.Button btnSİL;
        private System.Windows.Forms.Button btnGÜncelle;
    }
}