namespace HastaTakip
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
			this.txtAdi = new System.Windows.Forms.TextBox();
			this.txtUcret = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnHesapla = new System.Windows.Forms.Button();
			this.lblToplam = new System.Windows.Forms.Label();
			this.ClmnAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClmnDYili = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClmnCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClmnİndirimliÜcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClmnYas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtAdi
			// 
			this.txtAdi.Location = new System.Drawing.Point(102, 37);
			this.txtAdi.Name = "txtAdi";
			this.txtAdi.Size = new System.Drawing.Size(100, 20);
			this.txtAdi.TabIndex = 0;
			// 
			// txtUcret
			// 
			this.txtUcret.Location = new System.Drawing.Point(410, 100);
			this.txtUcret.Name = "txtUcret";
			this.txtUcret.Size = new System.Drawing.Size(111, 20);
			this.txtUcret.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Adı: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Doğum Tarihi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(314, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ücreti";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(306, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Cinsiyet";
			// 
			// cmbCinsiyet
			// 
			this.cmbCinsiyet.FormattingEnabled = true;
			this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
			this.cmbCinsiyet.Location = new System.Drawing.Point(410, 36);
			this.cmbCinsiyet.Name = "cmbCinsiyet";
			this.cmbCinsiyet.Size = new System.Drawing.Size(121, 21);
			this.cmbCinsiyet.TabIndex = 8;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnAdi,
            this.ClmnDYili,
            this.ClmnCinsiyet,
            this.ClmnİndirimliÜcret,
            this.ClmnYas});
			this.dataGridView1.Location = new System.Drawing.Point(17, 160);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(655, 175);
			this.dataGridView1.TabIndex = 9;
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(673, 95);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(90, 35);
			this.btnEkle.TabIndex = 10;
			this.btnEkle.Text = "Hasta Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// btnHesapla
			// 
			this.btnHesapla.Location = new System.Drawing.Point(673, 30);
			this.btnHesapla.Name = "btnHesapla";
			this.btnHesapla.Size = new System.Drawing.Size(90, 32);
			this.btnHesapla.TabIndex = 11;
			this.btnHesapla.Text = "Hesapla";
			this.btnHesapla.UseVisualStyleBackColor = true;
			// 
			// lblToplam
			// 
			this.lblToplam.AutoSize = true;
			this.lblToplam.Location = new System.Drawing.Point(538, 434);
			this.lblToplam.Name = "lblToplam";
			this.lblToplam.Size = new System.Drawing.Size(10, 13);
			this.lblToplam.TabIndex = 12;
			this.lblToplam.Text = " ";
			// 
			// ClmnAdi
			// 
			this.ClmnAdi.HeaderText = "Adı:";
			this.ClmnAdi.Name = "ClmnAdi";
			// 
			// ClmnDYili
			// 
			this.ClmnDYili.HeaderText = "Doğum Tarihi";
			this.ClmnDYili.Name = "ClmnDYili";
			// 
			// ClmnCinsiyet
			// 
			this.ClmnCinsiyet.HeaderText = "Cinsiyet";
			this.ClmnCinsiyet.Name = "ClmnCinsiyet";
			// 
			// ClmnİndirimliÜcret
			// 
			this.ClmnİndirimliÜcret.HeaderText = "İndirimi Ücret";
			this.ClmnİndirimliÜcret.Name = "ClmnİndirimliÜcret";
			// 
			// ClmnYas
			// 
			this.ClmnYas.HeaderText = "Yaşı";
			this.ClmnYas.Name = "ClmnYas";
			// 
			// dateDogumTarihi
			// 
			this.dateDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateDogumTarihi.Location = new System.Drawing.Point(102, 100);
			this.dateDogumTarihi.Name = "dateDogumTarihi";
			this.dateDogumTarihi.Size = new System.Drawing.Size(143, 20);
			this.dateDogumTarihi.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Coral;
			this.ClientSize = new System.Drawing.Size(843, 580);
			this.Controls.Add(this.dateDogumTarihi);
			this.Controls.Add(this.lblToplam);
			this.Controls.Add(this.btnHesapla);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.cmbCinsiyet);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUcret);
			this.Controls.Add(this.txtAdi);
			this.Name = "Form1";
			this.Text = "Hasta Takip";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtAdi;
		private System.Windows.Forms.TextBox txtUcret;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbCinsiyet;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnHesapla;
		private System.Windows.Forms.Label lblToplam;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClmnAdi;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDYili;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCinsiyet;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClmnİndirimliÜcret;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClmnYas;
		private System.Windows.Forms.DateTimePicker dateDogumTarihi;
	}
}

