using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakip
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			DateTime dogumTarihi = dateDogumTarihi.Value;




			Hasta hasta = new Hasta
			{
				Adi = txtAdi.Text,
				DogumYili = dogumTarihi.Year,
				Cinsiyet = cmbCinsiyet.Text,
				Ucret = Convert.ToInt32(txtUcret.Text)
			};



			hasta.YasHesapla();
			hasta.IndirimliUcretHesapla();

			dataGridView1.Rows.Add(hasta.Adi, hasta.DogumYili, hasta.Cinsiyet, hasta.IndirimliUcrt, hasta.Yas);


		}
	}
}
