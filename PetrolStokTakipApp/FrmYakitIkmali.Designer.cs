namespace PetrolStokTakipApp
{
    partial class FrmYakitIkmali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYakitIkmali));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CBXBenzinler = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NMRLitre = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLTutar = new System.Windows.Forms.Label();
            this.BTNDepoDoldur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMRLitre)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(323, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 451);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 44);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CBXBenzinler
            // 
            this.CBXBenzinler.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.CBXBenzinler.FormattingEnabled = true;
            this.CBXBenzinler.Location = new System.Drawing.Point(181, 134);
            this.CBXBenzinler.Name = "CBXBenzinler";
            this.CBXBenzinler.Size = new System.Drawing.Size(124, 26);
            this.CBXBenzinler.TabIndex = 20;
            this.CBXBenzinler.SelectedIndexChanged += new System.EventHandler(this.CBXBenzinler_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(70, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Benzin Türü:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Litre:";
            // 
            // NMRLitre
            // 
            this.NMRLitre.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.NMRLitre.Location = new System.Drawing.Point(181, 185);
            this.NMRLitre.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NMRLitre.Name = "NMRLitre";
            this.NMRLitre.Size = new System.Drawing.Size(124, 25);
            this.NMRLitre.TabIndex = 0;
            this.NMRLitre.ValueChanged += new System.EventHandler(this.NMRLitre_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tutar:";
            // 
            // LBLTutar
            // 
            this.LBLTutar.AutoSize = true;
            this.LBLTutar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.LBLTutar.ForeColor = System.Drawing.Color.White;
            this.LBLTutar.Location = new System.Drawing.Point(181, 231);
            this.LBLTutar.Name = "LBLTutar";
            this.LBLTutar.Size = new System.Drawing.Size(46, 21);
            this.LBLTutar.TabIndex = 23;
            this.LBLTutar.Text = "00,00";
            // 
            // BTNDepoDoldur
            // 
            this.BTNDepoDoldur.BackColor = System.Drawing.Color.White;
            this.BTNDepoDoldur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDepoDoldur.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNDepoDoldur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.BTNDepoDoldur.Location = new System.Drawing.Point(74, 272);
            this.BTNDepoDoldur.Name = "BTNDepoDoldur";
            this.BTNDepoDoldur.Size = new System.Drawing.Size(231, 38);
            this.BTNDepoDoldur.TabIndex = 24;
            this.BTNDepoDoldur.Text = "Yakıt İkmal\'i Yap";
            this.BTNDepoDoldur.UseVisualStyleBackColor = false;
            this.BTNDepoDoldur.Click += new System.EventHandler(this.BTNDepoDoldur_Click);
            // 
            // FrmYakitIkmali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(371, 494);
            this.Controls.Add(this.BTNDepoDoldur);
            this.Controls.Add(this.LBLTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NMRLitre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CBXBenzinler);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYakitIkmali";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYakitIkmali";
            this.Load += new System.EventHandler(this.FrmYakitIkmali_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMRLitre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CBXBenzinler;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NMRLitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLTutar;
        private System.Windows.Forms.Button BTNDepoDoldur;
    }
}