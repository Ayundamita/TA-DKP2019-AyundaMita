namespace formTAmita
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RESET = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.KETENTUAN = new System.Windows.Forms.Button();
            this.HITUNG = new System.Windows.Forms.Button();
            this.Asuransi = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BIAYA = new System.Windows.Forms.Label();
            this.BIAYA1 = new System.Windows.Forms.Label();
            this.PAJAK = new System.Windows.Forms.Label();
            this.PAJAK1 = new System.Windows.Forms.Label();
            this.ASURANSI0 = new System.Windows.Forms.Label();
            this.ASURANSI1 = new System.Windows.Forms.Label();
            this.BIAYATOTAL = new System.Windows.Forms.Label();
            this.BIAYATOTAL1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ekonomis",
            "Reguler",
            "Express",
            "Istimewa"});
            this.comboBox1.Location = new System.Drawing.Point(72, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(570, 315);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(109, 39);
            this.RESET.TabIndex = 1;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // KETENTUAN
            // 
            this.KETENTUAN.Location = new System.Drawing.Point(72, 314);
            this.KETENTUAN.Name = "KETENTUAN";
            this.KETENTUAN.Size = new System.Drawing.Size(121, 40);
            this.KETENTUAN.TabIndex = 6;
            this.KETENTUAN.Text = "KETENTUAN";
            this.KETENTUAN.UseVisualStyleBackColor = true;
            this.KETENTUAN.Click += new System.EventHandler(this.KETENTUAN_Click);
            // 
            // HITUNG
            // 
            this.HITUNG.Location = new System.Drawing.Point(240, 315);
            this.HITUNG.Name = "HITUNG";
            this.HITUNG.Size = new System.Drawing.Size(98, 38);
            this.HITUNG.TabIndex = 7;
            this.HITUNG.Text = "HITUNG";
            this.HITUNG.UseVisualStyleBackColor = true;
            this.HITUNG.Click += new System.EventHandler(this.HITUNG_Click);
            // 
            // Asuransi
            // 
            this.Asuransi.AutoSize = true;
            this.Asuransi.Location = new System.Drawing.Point(72, 262);
            this.Asuransi.Name = "Asuransi";
            this.Asuransi.Size = new System.Drawing.Size(97, 24);
            this.Asuransi.TabIndex = 9;
            this.Asuransi.Text = "Asuransi";
            this.Asuransi.UseVisualStyleBackColor = true;
            this.Asuransi.CheckedChanged += new System.EventHandler(this.Asuransi_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Jenis Pengiriman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Jarak Pengiriman";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Berat Barang Paket";
            // 
            // BIAYA
            // 
            this.BIAYA.AutoSize = true;
            this.BIAYA.Location = new System.Drawing.Point(474, 77);
            this.BIAYA.Name = "BIAYA";
            this.BIAYA.Size = new System.Drawing.Size(13, 20);
            this.BIAYA.TabIndex = 13;
            this.BIAYA.Text = " ";
            // 
            // BIAYA1
            // 
            this.BIAYA1.AutoSize = true;
            this.BIAYA1.Location = new System.Drawing.Point(474, 98);
            this.BIAYA1.Name = "BIAYA1";
            this.BIAYA1.Size = new System.Drawing.Size(13, 20);
            this.BIAYA1.TabIndex = 14;
            this.BIAYA1.Text = " ";
            // 
            // PAJAK
            // 
            this.PAJAK.AutoSize = true;
            this.PAJAK.Location = new System.Drawing.Point(474, 132);
            this.PAJAK.Name = "PAJAK";
            this.PAJAK.Size = new System.Drawing.Size(13, 20);
            this.PAJAK.TabIndex = 15;
            this.PAJAK.Text = " ";
            // 
            // PAJAK1
            // 
            this.PAJAK1.AutoSize = true;
            this.PAJAK1.Location = new System.Drawing.Point(474, 152);
            this.PAJAK1.Name = "PAJAK1";
            this.PAJAK1.Size = new System.Drawing.Size(13, 20);
            this.PAJAK1.TabIndex = 16;
            this.PAJAK1.Text = " ";
            // 
            // ASURANSI0
            // 
            this.ASURANSI0.AutoSize = true;
            this.ASURANSI0.Location = new System.Drawing.Point(474, 185);
            this.ASURANSI0.Name = "ASURANSI0";
            this.ASURANSI0.Size = new System.Drawing.Size(13, 20);
            this.ASURANSI0.TabIndex = 17;
            this.ASURANSI0.Text = " ";
            this.ASURANSI0.Click += new System.EventHandler(this.label8_Click);
            // 
            // ASURANSI1
            // 
            this.ASURANSI1.AutoSize = true;
            this.ASURANSI1.Location = new System.Drawing.Point(474, 205);
            this.ASURANSI1.Name = "ASURANSI1";
            this.ASURANSI1.Size = new System.Drawing.Size(13, 20);
            this.ASURANSI1.TabIndex = 18;
            this.ASURANSI1.Text = " ";
            // 
            // BIAYATOTAL
            // 
            this.BIAYATOTAL.AutoSize = true;
            this.BIAYATOTAL.Location = new System.Drawing.Point(474, 248);
            this.BIAYATOTAL.Name = "BIAYATOTAL";
            this.BIAYATOTAL.Size = new System.Drawing.Size(13, 20);
            this.BIAYATOTAL.TabIndex = 19;
            this.BIAYATOTAL.Text = " ";
            // 
            // BIAYATOTAL1
            // 
            this.BIAYATOTAL1.AutoSize = true;
            this.BIAYATOTAL1.Location = new System.Drawing.Point(474, 277);
            this.BIAYATOTAL1.Name = "BIAYATOTAL1";
            this.BIAYATOTAL1.Size = new System.Drawing.Size(13, 20);
            this.BIAYATOTAL1.TabIndex = 20;
            this.BIAYATOTAL1.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Brush Script MT", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(287, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 39);
            this.label4.TabIndex = 21;
            this.label4.Text = "Pengiriman Paket Mitul";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Matura MT Script Capitals", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(755, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Terima Kasih";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "kg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(906, 391);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BIAYATOTAL1);
            this.Controls.Add(this.BIAYATOTAL);
            this.Controls.Add(this.ASURANSI1);
            this.Controls.Add(this.ASURANSI0);
            this.Controls.Add(this.PAJAK1);
            this.Controls.Add(this.PAJAK);
            this.Controls.Add(this.BIAYA1);
            this.Controls.Add(this.BIAYA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Asuransi);
            this.Controls.Add(this.HITUNG);
            this.Controls.Add(this.KETENTUAN);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button KETENTUAN;
        private System.Windows.Forms.Button HITUNG;
        private System.Windows.Forms.CheckBox Asuransi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BIAYA;
        private System.Windows.Forms.Label BIAYA1;
        private System.Windows.Forms.Label PAJAK;
        private System.Windows.Forms.Label PAJAK1;
        private System.Windows.Forms.Label ASURANSI0;
        private System.Windows.Forms.Label ASURANSI1;
        private System.Windows.Forms.Label BIAYATOTAL;
        private System.Windows.Forms.Label BIAYATOTAL1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

