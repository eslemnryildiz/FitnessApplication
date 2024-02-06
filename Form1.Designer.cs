namespace FitnessApplication
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSporcular = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnOdemeler = new System.Windows.Forms.Button();
            this.btnVucutOlculeri = new System.Windows.Forms.Button();
            this.btnGunler = new System.Windows.Forms.Button();
            this.btnEgzersizler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSporcular
            // 
            this.btnSporcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSporcular.BackgroundImage")));
            this.btnSporcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSporcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSporcular.ForeColor = System.Drawing.Color.Brown;
            this.btnSporcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSporcular.ImageKey = "(yok)";
            this.btnSporcular.Location = new System.Drawing.Point(37, 25);
            this.btnSporcular.Name = "btnSporcular";
            this.btnSporcular.Size = new System.Drawing.Size(168, 168);
            this.btnSporcular.TabIndex = 0;
            this.btnSporcular.Text = "Sporcular";
            this.btnSporcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSporcular.UseVisualStyleBackColor = true;
            this.btnSporcular.Click += new System.EventHandler(this.btnSporcular_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(1083, 159);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(68, 59);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnOdemeler
            // 
            this.btnOdemeler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOdemeler.BackgroundImage")));
            this.btnOdemeler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOdemeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeler.ForeColor = System.Drawing.Color.Brown;
            this.btnOdemeler.Location = new System.Drawing.Point(255, 25);
            this.btnOdemeler.Name = "btnOdemeler";
            this.btnOdemeler.Size = new System.Drawing.Size(168, 168);
            this.btnOdemeler.TabIndex = 1;
            this.btnOdemeler.Text = "Ödemeler";
            this.btnOdemeler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOdemeler.UseVisualStyleBackColor = true;
            this.btnOdemeler.Click += new System.EventHandler(this.btnOdemeler_Click);
            // 
            // btnVucutOlculeri
            // 
            this.btnVucutOlculeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVucutOlculeri.BackgroundImage")));
            this.btnVucutOlculeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVucutOlculeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVucutOlculeri.ForeColor = System.Drawing.Color.Brown;
            this.btnVucutOlculeri.Location = new System.Drawing.Point(470, 25);
            this.btnVucutOlculeri.Name = "btnVucutOlculeri";
            this.btnVucutOlculeri.Size = new System.Drawing.Size(168, 168);
            this.btnVucutOlculeri.TabIndex = 2;
            this.btnVucutOlculeri.Text = "Vücut Ölçüleri";
            this.btnVucutOlculeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVucutOlculeri.UseVisualStyleBackColor = true;
            this.btnVucutOlculeri.Click += new System.EventHandler(this.btnVucutOlculeri_Click);
            // 
            // btnGunler
            // 
            this.btnGunler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGunler.BackgroundImage")));
            this.btnGunler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunler.ForeColor = System.Drawing.Color.Brown;
            this.btnGunler.Location = new System.Drawing.Point(898, 25);
            this.btnGunler.Name = "btnGunler";
            this.btnGunler.Size = new System.Drawing.Size(168, 168);
            this.btnGunler.TabIndex = 4;
            this.btnGunler.Text = "Günler";
            this.btnGunler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGunler.UseVisualStyleBackColor = true;
            this.btnGunler.Click += new System.EventHandler(this.btnGunler_Click);
            // 
            // btnEgzersizler
            // 
            this.btnEgzersizler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEgzersizler.BackgroundImage")));
            this.btnEgzersizler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEgzersizler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEgzersizler.ForeColor = System.Drawing.Color.Brown;
            this.btnEgzersizler.Location = new System.Drawing.Point(690, 25);
            this.btnEgzersizler.Name = "btnEgzersizler";
            this.btnEgzersizler.Size = new System.Drawing.Size(168, 168);
            this.btnEgzersizler.TabIndex = 3;
            this.btnEgzersizler.Text = "Egzersizler";
            this.btnEgzersizler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEgzersizler.UseVisualStyleBackColor = true;
            this.btnEgzersizler.Click += new System.EventHandler(this.btnEgzersizler_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.btnSporcular);
            this.panel1.Controls.Add(this.btnVucutOlculeri);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnGunler);
            this.panel1.Controls.Add(this.btnEgzersizler);
            this.panel1.Controls.Add(this.btnOdemeler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 230);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1163, 768);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSporcular;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnOdemeler;
        private System.Windows.Forms.Button btnVucutOlculeri;
        private System.Windows.Forms.Button btnGunler;
        private System.Windows.Forms.Button btnEgzersizler;
        private System.Windows.Forms.Panel panel1;
    }
}

