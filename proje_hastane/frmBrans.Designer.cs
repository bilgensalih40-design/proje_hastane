namespace proje_hastane
{
    partial class frmBrans
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
            this.btnGÜncelle = new System.Windows.Forms.Button();
            this.btnSİL = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbRANS = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGÜncelle
            // 
            this.btnGÜncelle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnGÜncelle.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGÜncelle.Location = new System.Drawing.Point(112, 229);
            this.btnGÜncelle.Name = "btnGÜncelle";
            this.btnGÜncelle.Size = new System.Drawing.Size(260, 39);
            this.btnGÜncelle.TabIndex = 28;
            this.btnGÜncelle.Text = "GÜNCELLE";
            this.btnGÜncelle.UseVisualStyleBackColor = false;
            this.btnGÜncelle.Click += new System.EventHandler(this.btnGÜncelle_Click);
            // 
            // btnSİL
            // 
            this.btnSİL.BackColor = System.Drawing.Color.Crimson;
            this.btnSİL.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSİL.Location = new System.Drawing.Point(263, 167);
            this.btnSİL.Name = "btnSİL";
            this.btnSİL.Size = new System.Drawing.Size(83, 36);
            this.btnSİL.TabIndex = 27;
            this.btnSİL.Text = "SİL";
            this.btnSİL.UseVisualStyleBackColor = false;
            this.btnSİL.Click += new System.EventHandler(this.btnSİL_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEkle.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(145, 167);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(84, 36);
            this.btnEkle.TabIndex = 26;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(407, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(513, 262);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtbRANS
            // 
            this.txtbRANS.Location = new System.Drawing.Point(141, 105);
            this.txtbRANS.Name = "txtbRANS";
            this.txtbRANS.Size = new System.Drawing.Size(260, 22);
            this.txtbRANS.TabIndex = 21;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(141, 41);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(260, 22);
            this.txtAd.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "BRANŞ AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "BRANŞ ID:";
            // 
            // frmBrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(932, 296);
            this.Controls.Add(this.btnGÜncelle);
            this.Controls.Add(this.btnSİL);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbRANS);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBrans";
            this.Text = "Branş Paneli";
            this.Load += new System.EventHandler(this.frmBrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGÜncelle;
        private System.Windows.Forms.Button btnSİL;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbRANS;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}