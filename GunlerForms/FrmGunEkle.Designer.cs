namespace FitnessApplication
{
    partial class FrmGunEkle
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
            this.label13 = new System.Windows.Forms.Label();
            this.txtSporcuId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPazartesi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCarsamba = new System.Windows.Forms.ComboBox();
            this.cmbPersembe = new System.Windows.Forms.ComboBox();
            this.cmbCuma = new System.Windows.Forms.ComboBox();
            this.cmbSali = new System.Windows.Forms.ComboBox();
            this.cmbPazar = new System.Windows.Forms.ComboBox();
            this.cmbCumartesi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Brown;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(1031, 594);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(112, 76);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Brown;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(718, 545);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(173, 43);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Brown;
            this.label13.Location = new System.Drawing.Point(465, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(304, 48);
            this.label13.TabIndex = 83;
            this.label13.Text = "GÜN EKLEME";
            // 
            // txtSporcuId
            // 
            this.txtSporcuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSporcuId.ForeColor = System.Drawing.Color.Brown;
            this.txtSporcuId.Location = new System.Drawing.Point(295, 199);
            this.txtSporcuId.Multiline = true;
            this.txtSporcuId.Name = "txtSporcuId";
            this.txtSporcuId.Size = new System.Drawing.Size(237, 35);
            this.txtSporcuId.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(69, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 75;
            this.label1.Text = "Sporcu Id:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.ForeColor = System.Drawing.Color.Brown;
            this.txtId.Location = new System.Drawing.Point(295, 145);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(237, 35);
            this.txtId.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(163, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 29);
            this.label5.TabIndex = 86;
            this.label5.Text = "Id:";
            // 
            // cmbPazartesi
            // 
            this.cmbPazartesi.FormattingEnabled = true;
            this.cmbPazartesi.Items.AddRange(new object[] {
            "evet",
            "hayir"});
            this.cmbPazartesi.Location = new System.Drawing.Point(295, 261);
            this.cmbPazartesi.Name = "cmbPazartesi";
            this.cmbPazartesi.Size = new System.Drawing.Size(240, 24);
            this.cmbPazartesi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(78, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 89;
            this.label2.Text = "Pazartesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(146, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 91;
            this.label3.Text = "Salı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(68, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 93;
            this.label4.Text = "Çarşamba";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(68, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 29);
            this.label6.TabIndex = 95;
            this.label6.Text = "Perşembe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(120, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 29);
            this.label7.TabIndex = 97;
            this.label7.Text = "Cuma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(67, 559);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 29);
            this.label8.TabIndex = 99;
            this.label8.Text = "Cumartesi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(122, 616);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 29);
            this.label9.TabIndex = 101;
            this.label9.Text = "Pazar";
            // 
            // cmbCarsamba
            // 
            this.cmbCarsamba.FormattingEnabled = true;
            this.cmbCarsamba.Items.AddRange(new object[] {
            "evet",
            "hayir"});
            this.cmbCarsamba.Location = new System.Drawing.Point(295, 380);
            this.cmbCarsamba.Name = "cmbCarsamba";
            this.cmbCarsamba.Size = new System.Drawing.Size(240, 24);
            this.cmbCarsamba.TabIndex = 2;
            // 
            // cmbPersembe
            // 
            this.cmbPersembe.FormattingEnabled = true;
            this.cmbPersembe.Items.AddRange(new object[] {
            "evet",
            "hayir"});
            this.cmbPersembe.Location = new System.Drawing.Point(295, 440);
            this.cmbPersembe.Name = "cmbPersembe";
            this.cmbPersembe.Size = new System.Drawing.Size(240, 24);
            this.cmbPersembe.TabIndex = 3;
            // 
            // cmbCuma
            // 
            this.cmbCuma.FormattingEnabled = true;
            this.cmbCuma.Items.AddRange(new object[] {
            "evet",
            "hayir"});
            this.cmbCuma.Location = new System.Drawing.Point(295, 506);
            this.cmbCuma.Name = "cmbCuma";
            this.cmbCuma.Size = new System.Drawing.Size(240, 24);
            this.cmbCuma.TabIndex = 4;
            // 
            // cmbSali
            // 
            this.cmbSali.FormattingEnabled = true;
            this.cmbSali.Items.AddRange(new object[] {
            "evet",
            "hayir"});
            this.cmbSali.Location = new System.Drawing.Point(295, 321);
            this.cmbSali.Name = "cmbSali";
            this.cmbSali.Size = new System.Drawing.Size(240, 24);
            this.cmbSali.TabIndex = 1;
            // 
            // cmbPazar
            // 
            this.cmbPazar.FormattingEnabled = true;
            this.cmbPazar.Items.AddRange(new object[] {
            "evet",
            "hayir"});
            this.cmbPazar.Location = new System.Drawing.Point(295, 624);
            this.cmbPazar.Name = "cmbPazar";
            this.cmbPazar.Size = new System.Drawing.Size(240, 24);
            this.cmbPazar.TabIndex = 6;
            // 
            // cmbCumartesi
            // 
            this.cmbCumartesi.FormattingEnabled = true;
            this.cmbCumartesi.Items.AddRange(new object[] {
            "evet",
            "hayir"});
            this.cmbCumartesi.Location = new System.Drawing.Point(295, 567);
            this.cmbCumartesi.Name = "cmbCumartesi";
            this.cmbCumartesi.Size = new System.Drawing.Size(240, 24);
            this.cmbCumartesi.TabIndex = 5;
            // 
            // FrmGunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 734);
            this.Controls.Add(this.cmbCumartesi);
            this.Controls.Add(this.cmbPazar);
            this.Controls.Add(this.cmbSali);
            this.Controls.Add(this.cmbCuma);
            this.Controls.Add(this.cmbPersembe);
            this.Controls.Add(this.cmbCarsamba);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPazartesi);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSporcuId);
            this.Controls.Add(this.label1);
            this.Name = "FrmGunEkle";
            this.Text = "FrmGunEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSporcuId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPazartesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCarsamba;
        private System.Windows.Forms.ComboBox cmbPersembe;
        private System.Windows.Forms.ComboBox cmbCuma;
        private System.Windows.Forms.ComboBox cmbSali;
        private System.Windows.Forms.ComboBox cmbPazar;
        private System.Windows.Forms.ComboBox cmbCumartesi;
    }
}