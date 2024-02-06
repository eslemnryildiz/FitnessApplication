namespace FitnessApplication
{
    partial class FrmVucutOlcuListesi
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
            this.txtSporcuAd = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnOlcuGuncelle = new System.Windows.Forms.Button();
            this.btnOdemeSil = new System.Windows.Forms.Button();
            this.btnOlcuEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Brown;
            this.dataGridView1.Location = new System.Drawing.Point(54, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1034, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.txtSporcuAd);
            this.panel1.Controls.Add(this.S);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.btnOlcuGuncelle);
            this.panel1.Controls.Add(this.btnOdemeSil);
            this.panel1.Controls.Add(this.btnOlcuEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 157);
            this.panel1.TabIndex = 1;
            // 
            // txtSporcuAd
            // 
            this.txtSporcuAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSporcuAd.ForeColor = System.Drawing.Color.Brown;
            this.txtSporcuAd.Location = new System.Drawing.Point(370, 26);
            this.txtSporcuAd.Multiline = true;
            this.txtSporcuAd.Name = "txtSporcuAd";
            this.txtSporcuAd.Size = new System.Drawing.Size(357, 38);
            this.txtSporcuAd.TabIndex = 0;
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.S.ForeColor = System.Drawing.Color.White;
            this.S.Location = new System.Drawing.Point(193, 35);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(155, 29);
            this.S.TabIndex = 21;
            this.S.Text = "Sporcu Adı:";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.Brown;
            this.btnAra.Location = new System.Drawing.Point(798, 26);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(138, 40);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.Brown;
            this.btnKapat.Location = new System.Drawing.Point(995, 94);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(138, 40);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnOlcuGuncelle
            // 
            this.btnOlcuGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlcuGuncelle.ForeColor = System.Drawing.Color.Brown;
            this.btnOlcuGuncelle.Location = new System.Drawing.Point(641, 94);
            this.btnOlcuGuncelle.Name = "btnOlcuGuncelle";
            this.btnOlcuGuncelle.Size = new System.Drawing.Size(185, 40);
            this.btnOlcuGuncelle.TabIndex = 4;
            this.btnOlcuGuncelle.Text = "Ölçü Güncelle";
            this.btnOlcuGuncelle.UseVisualStyleBackColor = true;
            this.btnOlcuGuncelle.Click += new System.EventHandler(this.btnOlcuGuncelle_Click);
            // 
            // btnOdemeSil
            // 
            this.btnOdemeSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeSil.ForeColor = System.Drawing.Color.Brown;
            this.btnOdemeSil.Location = new System.Drawing.Point(313, 94);
            this.btnOdemeSil.Name = "btnOdemeSil";
            this.btnOdemeSil.Size = new System.Drawing.Size(135, 40);
            this.btnOdemeSil.TabIndex = 3;
            this.btnOdemeSil.Text = "Ölçü Sil";
            this.btnOdemeSil.UseVisualStyleBackColor = true;
            this.btnOdemeSil.Click += new System.EventHandler(this.btnOdemeSil_Click);
            // 
            // btnOlcuEkle
            // 
            this.btnOlcuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlcuEkle.ForeColor = System.Drawing.Color.Brown;
            this.btnOlcuEkle.Location = new System.Drawing.Point(12, 94);
            this.btnOlcuEkle.Name = "btnOlcuEkle";
            this.btnOlcuEkle.Size = new System.Drawing.Size(138, 40);
            this.btnOlcuEkle.TabIndex = 2;
            this.btnOlcuEkle.Text = "Ölçü Ekle";
            this.btnOlcuEkle.UseVisualStyleBackColor = true;
            this.btnOlcuEkle.Click += new System.EventHandler(this.btnOlcuEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(449, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "ÖLÇÜM LİSTESİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(341, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "AKÜ FİTNESS SALONU";
            // 
            // FrmVucutOlcuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 773);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVucutOlcuListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVucutOlcuListesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSporcuAd;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnOlcuGuncelle;
        private System.Windows.Forms.Button btnOdemeSil;
        private System.Windows.Forms.Button btnOlcuEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}