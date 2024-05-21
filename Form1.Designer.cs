namespace BMI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHasilBMI = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtUsia = new System.Windows.Forms.TextBox();
            this.txtTinggiBadan = new System.Windows.Forms.TextBox();
            this.txtBeratBadan = new System.Windows.Forms.TextBox();
            this.cmbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.txtHasilBMI = new System.Windows.Forms.TextBox();
            this.lblKeteranganHasil = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 78);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Index Masa Tubuh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tinggi Badan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Berat Badan";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hasil BMI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Keterangan";
            // 
            // btnHasilBMI
            // 
            this.btnHasilBMI.Location = new System.Drawing.Point(190, 309);
            this.btnHasilBMI.Name = "btnHasilBMI";
            this.btnHasilBMI.Size = new System.Drawing.Size(142, 26);
            this.btnHasilBMI.TabIndex = 8;
            this.btnHasilBMI.Text = "Hasil BMI";
            this.btnHasilBMI.UseVisualStyleBackColor = true;
            this.btnHasilBMI.Click += new System.EventHandler(this.btnHasilBMI_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(201, 120);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(106, 20);
            this.txtNama.TabIndex = 9;
            // 
            // txtUsia
            // 
            this.txtUsia.Location = new System.Drawing.Point(201, 154);
            this.txtUsia.Name = "txtUsia";
            this.txtUsia.Size = new System.Drawing.Size(106, 20);
            this.txtUsia.TabIndex = 10;
            // 
            // txtTinggiBadan
            // 
            this.txtTinggiBadan.Location = new System.Drawing.Point(201, 240);
            this.txtTinggiBadan.Name = "txtTinggiBadan";
            this.txtTinggiBadan.Size = new System.Drawing.Size(106, 20);
            this.txtTinggiBadan.TabIndex = 11;
            // 
            // txtBeratBadan
            // 
            this.txtBeratBadan.Location = new System.Drawing.Point(201, 277);
            this.txtBeratBadan.Name = "txtBeratBadan";
            this.txtBeratBadan.Size = new System.Drawing.Size(106, 20);
            this.txtBeratBadan.TabIndex = 12;
            // 
            // cmbJenisKelamin
            // 
            this.cmbJenisKelamin.FormattingEnabled = true;
            this.cmbJenisKelamin.Items.AddRange(new object[] {
            "Laki Laki",
            "Perempuan"});
            this.cmbJenisKelamin.Location = new System.Drawing.Point(201, 185);
            this.cmbJenisKelamin.Name = "cmbJenisKelamin";
            this.cmbJenisKelamin.Size = new System.Drawing.Size(121, 21);
            this.cmbJenisKelamin.TabIndex = 13;
            // 
            // txtHasilBMI
            // 
            this.txtHasilBMI.Location = new System.Drawing.Point(201, 358);
            this.txtHasilBMI.Name = "txtHasilBMI";
            this.txtHasilBMI.Size = new System.Drawing.Size(106, 20);
            this.txtHasilBMI.TabIndex = 14;
            // 
            // lblKeteranganHasil
            // 
            this.lblKeteranganHasil.AutoSize = true;
            this.lblKeteranganHasil.Location = new System.Drawing.Point(198, 387);
            this.lblKeteranganHasil.Name = "lblKeteranganHasil";
            this.lblKeteranganHasil.Size = new System.Drawing.Size(0, 13);
            this.lblKeteranganHasil.TabIndex = 15;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(163, 412);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(76, 26);
            this.btnHapus.TabIndex = 16;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(276, 412);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(76, 26);
            this.btnKeluar.TabIndex = 17;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "CM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "KG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.lblKeteranganHasil);
            this.Controls.Add(this.txtHasilBMI);
            this.Controls.Add(this.cmbJenisKelamin);
            this.Controls.Add(this.txtBeratBadan);
            this.Controls.Add(this.txtTinggiBadan);
            this.Controls.Add(this.txtUsia);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.btnHasilBMI);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHasilBMI;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtUsia;
        private System.Windows.Forms.TextBox txtTinggiBadan;
        private System.Windows.Forms.TextBox txtBeratBadan;
        private System.Windows.Forms.ComboBox cmbJenisKelamin;
        private System.Windows.Forms.TextBox txtHasilBMI;
        private System.Windows.Forms.Label lblKeteranganHasil;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

