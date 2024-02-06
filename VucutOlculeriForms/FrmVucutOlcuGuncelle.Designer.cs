namespace FitnessApplication
{
    partial class FrmVucutOlcuGuncelle
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
            this.txtSporcuId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOlcuId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBelCevresi = new System.Windows.Forms.TextBox();
            this.txtGogusCevresi = new System.Windows.Forms.TextBox();
            this.txtKalcaCevresi = new System.Windows.Forms.TextBox();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dtpOlcumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtBoy = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(39, 506);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 239);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtSporcuId);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtOlcuId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBelCevresi);
            this.panel1.Controls.Add(this.txtGogusCevresi);
            this.panel1.Controls.Add(this.txtKalcaCevresi);
            this.panel1.Controls.Add(this.txtKilo);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.dtpOlcumTarihi);
            this.panel1.Controls.Add(this.txtBoy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 483);
            this.panel1.TabIndex = 0;
            // 
            // txtSporcuId
            // 
            this.txtSporcuId.Location = new System.Drawing.Point(233, 226);
            this.txtSporcuId.Multiline = true;
            this.txtSporcuId.Name = "txtSporcuId";
            this.txtSporcuId.ReadOnly = true;
            this.txtSporcuId.Size = new System.Drawing.Size(208, 35);
            this.txtSporcuId.TabIndex = 174;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(90, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 29);
            this.label10.TabIndex = 173;
            this.label10.Text = "Sporcu Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(345, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 48);
            this.label1.TabIndex = 172;
            this.label1.Text = "ÖLÇÜ GÜNCELLEME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(159, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 29);
            this.label9.TabIndex = 56;
            this.label9.Text = "Boy:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(26, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 29);
            this.label8.TabIndex = 55;
            this.label8.Text = "Göğüs Çevresi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(614, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 29);
            this.label7.TabIndex = 54;
            this.label7.Text = "Bel Çevresi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(585, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 29);
            this.label6.TabIndex = 53;
            this.label6.Text = "Kalça Çevresi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(599, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 29);
            this.label5.TabIndex = 52;
            this.label5.Text = "Ölçüm Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(159, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 51;
            this.label4.Text = "Kilo:";
            // 
            // txtOlcuId
            // 
            this.txtOlcuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOlcuId.ForeColor = System.Drawing.Color.Brown;
            this.txtOlcuId.Location = new System.Drawing.Point(233, 171);
            this.txtOlcuId.Multiline = true;
            this.txtOlcuId.Name = "txtOlcuId";
            this.txtOlcuId.ReadOnly = true;
            this.txtOlcuId.Size = new System.Drawing.Size(208, 35);
            this.txtOlcuId.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(120, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ölçü Id:";
            // 
            // txtBelCevresi
            // 
            this.txtBelCevresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBelCevresi.ForeColor = System.Drawing.Color.Brown;
            this.txtBelCevresi.Location = new System.Drawing.Point(794, 174);
            this.txtBelCevresi.Multiline = true;
            this.txtBelCevresi.Name = "txtBelCevresi";
            this.txtBelCevresi.Size = new System.Drawing.Size(208, 35);
            this.txtBelCevresi.TabIndex = 3;
            this.txtBelCevresi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBelCevresi_KeyPress);
            // 
            // txtGogusCevresi
            // 
            this.txtGogusCevresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGogusCevresi.ForeColor = System.Drawing.Color.Brown;
            this.txtGogusCevresi.Location = new System.Drawing.Point(233, 396);
            this.txtGogusCevresi.Multiline = true;
            this.txtGogusCevresi.Name = "txtGogusCevresi";
            this.txtGogusCevresi.Size = new System.Drawing.Size(208, 35);
            this.txtGogusCevresi.TabIndex = 2;
            this.txtGogusCevresi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGogusCevresi_KeyPress);
            // 
            // txtKalcaCevresi
            // 
            this.txtKalcaCevresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKalcaCevresi.ForeColor = System.Drawing.Color.Brown;
            this.txtKalcaCevresi.Location = new System.Drawing.Point(794, 232);
            this.txtKalcaCevresi.Multiline = true;
            this.txtKalcaCevresi.Name = "txtKalcaCevresi";
            this.txtKalcaCevresi.Size = new System.Drawing.Size(208, 35);
            this.txtKalcaCevresi.TabIndex = 4;
            this.txtKalcaCevresi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKalcaCevresi_KeyPress);
            // 
            // txtKilo
            // 
            this.txtKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKilo.ForeColor = System.Drawing.Color.Brown;
            this.txtKilo.Location = new System.Drawing.Point(233, 284);
            this.txtKilo.Multiline = true;
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(208, 35);
            this.txtKilo.TabIndex = 0;
            this.txtKilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKilo_KeyPress);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Brown;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(880, 379);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(161, 52);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Brown;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(577, 384);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(161, 52);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dtpOlcumTarihi
            // 
            this.dtpOlcumTarihi.Location = new System.Drawing.Point(794, 297);
            this.dtpOlcumTarihi.Name = "dtpOlcumTarihi";
            this.dtpOlcumTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpOlcumTarihi.TabIndex = 5;
            // 
            // txtBoy
            // 
            this.txtBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoy.ForeColor = System.Drawing.Color.Brown;
            this.txtBoy.Location = new System.Drawing.Point(233, 334);
            this.txtBoy.Multiline = true;
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(208, 35);
            this.txtBoy.TabIndex = 1;
            this.txtBoy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoy_KeyPress);
            // 
            // FrmVucutOlcuGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1160, 776);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVucutOlcuGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVucutOlcuGuncelle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBelCevresi;
        private System.Windows.Forms.TextBox txtGogusCevresi;
        private System.Windows.Forms.TextBox txtKalcaCevresi;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DateTimePicker dtpOlcumTarihi;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtOlcuId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSporcuId;
        private System.Windows.Forms.Label label10;
    }
}