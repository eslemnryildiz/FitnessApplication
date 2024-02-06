namespace FitnessApplication
{
    partial class FrmVucutOlcuEkle
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
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtpOlcumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.txtSporcuId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.txtBelCevresi = new System.Windows.Forms.TextBox();
            this.txtGogusCevresi = new System.Windows.Forms.TextBox();
            this.txtKalcaCevresi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Brown;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(724, 673);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(145, 53);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Brown;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(263, 673);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(145, 53);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dtpOlcumTarihi
            // 
            this.dtpOlcumTarihi.Location = new System.Drawing.Point(381, 601);
            this.dtpOlcumTarihi.Name = "dtpOlcumTarihi";
            this.dtpOlcumTarihi.Size = new System.Drawing.Size(249, 22);
            this.dtpOlcumTarihi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(269, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kilo:";
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(381, 312);
            this.txtBoy.Multiline = true;
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(249, 30);
            this.txtBoy.TabIndex = 1;
            this.txtBoy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoy_KeyPress);
            // 
            // txtSporcuId
            // 
            this.txtSporcuId.Location = new System.Drawing.Point(381, 166);
            this.txtSporcuId.Multiline = true;
            this.txtSporcuId.Name = "txtSporcuId";
            this.txtSporcuId.Size = new System.Drawing.Size(249, 30);
            this.txtSporcuId.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(200, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sporcu Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(160, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ölçüm Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(146, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Kalça Çevresi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(175, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Bel Çevresi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(136, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Göğüs Çevresi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(269, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "Boy:";
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(381, 241);
            this.txtKilo.Multiline = true;
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(249, 30);
            this.txtKilo.TabIndex = 0;
            this.txtKilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKilo_KeyPress);
            // 
            // txtBelCevresi
            // 
            this.txtBelCevresi.Location = new System.Drawing.Point(381, 446);
            this.txtBelCevresi.Multiline = true;
            this.txtBelCevresi.Name = "txtBelCevresi";
            this.txtBelCevresi.Size = new System.Drawing.Size(249, 30);
            this.txtBelCevresi.TabIndex = 3;
            this.txtBelCevresi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBelCevresi_KeyPress);
            // 
            // txtGogusCevresi
            // 
            this.txtGogusCevresi.Location = new System.Drawing.Point(381, 377);
            this.txtGogusCevresi.Multiline = true;
            this.txtGogusCevresi.Name = "txtGogusCevresi";
            this.txtGogusCevresi.Size = new System.Drawing.Size(249, 30);
            this.txtGogusCevresi.TabIndex = 2;
            this.txtGogusCevresi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGogusCevresi_KeyPress);
            // 
            // txtKalcaCevresi
            // 
            this.txtKalcaCevresi.Location = new System.Drawing.Point(381, 521);
            this.txtKalcaCevresi.Multiline = true;
            this.txtKalcaCevresi.Name = "txtKalcaCevresi";
            this.txtKalcaCevresi.Size = new System.Drawing.Size(249, 30);
            this.txtKalcaCevresi.TabIndex = 4;
            this.txtKalcaCevresi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKalcaCevresi_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Brown;
            this.label13.Location = new System.Drawing.Point(373, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(328, 48);
            this.label13.TabIndex = 72;
            this.label13.Text = "ÖLÇÜ EKLEME";
            // 
            // FrmVucutOlcuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 765);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBelCevresi);
            this.Controls.Add(this.txtGogusCevresi);
            this.Controls.Add(this.txtKalcaCevresi);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dtpOlcumTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.txtSporcuId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVucutOlcuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVucutOlcuEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dtpOlcumTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtSporcuId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.TextBox txtBelCevresi;
        private System.Windows.Forms.TextBox txtGogusCevresi;
        private System.Windows.Forms.TextBox txtKalcaCevresi;
        private System.Windows.Forms.Label label13;
    }
}