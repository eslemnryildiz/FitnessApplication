namespace FitnessApplication
{
    partial class FrmSporcuListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.Ad = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSporcuGuncelle = new System.Windows.Forms.Button();
            this.btnSporcuSil = new System.Windows.Forms.Button();
            this.btnSporcuEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.GridColor = System.Drawing.Color.Brown;
            this.dataGridView1.Location = new System.Drawing.Point(71, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.Ad);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.btnSporcuGuncelle);
            this.panel1.Controls.Add(this.btnSporcuSil);
            this.panel1.Controls.Add(this.btnSporcuEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 213);
            this.panel1.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.ForeColor = System.Drawing.Color.Brown;
            this.txtAd.Location = new System.Drawing.Point(71, 53);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(357, 38);
            this.txtAd.TabIndex = 0;
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad.ForeColor = System.Drawing.Color.Brown;
            this.Ad.Location = new System.Drawing.Point(11, 56);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(54, 29);
            this.Ad.TabIndex = 6;
            this.Ad.Text = "Ad:";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Brown;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(462, 47);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(161, 54);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Brown;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(1050, 128);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 73);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSporcuGuncelle
            // 
            this.btnSporcuGuncelle.BackColor = System.Drawing.Color.Brown;
            this.btnSporcuGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSporcuGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnSporcuGuncelle.Location = new System.Drawing.Point(810, 47);
            this.btnSporcuGuncelle.Name = "btnSporcuGuncelle";
            this.btnSporcuGuncelle.Size = new System.Drawing.Size(161, 54);
            this.btnSporcuGuncelle.TabIndex = 3;
            this.btnSporcuGuncelle.Text = "Sporcu Güncelle";
            this.btnSporcuGuncelle.UseVisualStyleBackColor = false;
            this.btnSporcuGuncelle.Click += new System.EventHandler(this.btnSporcuGuncelle_Click);
            // 
            // btnSporcuSil
            // 
            this.btnSporcuSil.BackColor = System.Drawing.Color.Brown;
            this.btnSporcuSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSporcuSil.ForeColor = System.Drawing.Color.White;
            this.btnSporcuSil.Location = new System.Drawing.Point(977, 46);
            this.btnSporcuSil.Name = "btnSporcuSil";
            this.btnSporcuSil.Size = new System.Drawing.Size(161, 54);
            this.btnSporcuSil.TabIndex = 4;
            this.btnSporcuSil.Text = "Sporcu Sil";
            this.btnSporcuSil.UseVisualStyleBackColor = false;
            this.btnSporcuSil.Click += new System.EventHandler(this.btnSporcuSil_Click);
            // 
            // btnSporcuEkle
            // 
            this.btnSporcuEkle.BackColor = System.Drawing.Color.Brown;
            this.btnSporcuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSporcuEkle.ForeColor = System.Drawing.Color.White;
            this.btnSporcuEkle.Location = new System.Drawing.Point(643, 47);
            this.btnSporcuEkle.Name = "btnSporcuEkle";
            this.btnSporcuEkle.Size = new System.Drawing.Size(161, 54);
            this.btnSporcuEkle.TabIndex = 2;
            this.btnSporcuEkle.Text = "Sporcu Ekle";
            this.btnSporcuEkle.UseVisualStyleBackColor = false;
            this.btnSporcuEkle.Click += new System.EventHandler(this.btnSporcuEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(318, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "AKÜ FİTNESS SALONU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(407, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "SPORCU LİSTESİ";
            // 
            // FrmSporcuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(1162, 728);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSporcuListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSporcuListesi";
            this.Load += new System.EventHandler(this.FrmSporcuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSporcuSil;
        private System.Windows.Forms.Button btnSporcuEkle;
        private System.Windows.Forms.Button btnSporcuGuncelle;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}