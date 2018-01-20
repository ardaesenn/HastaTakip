using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip
{
	class Hasta
	{
		

		
		public string Adi;
		public int Ucret;
		public int DogumYili;
		public string Cinsiyet;

		public int Yas;
		public int IndirimliUcrt;

		public void YasHesapla()
		{
			Yas = DateTime.Now.Year - DogumYili;

		}
		public void IndirimliUcretHesapla()
		{
			if (Yas > 65)
			{
				IndirimliUcrt = 0;
			}
			else if (Cinsiyet == "Kadın")
			{
				IndirimliUcrt = Ucret * 80 / 100;
			}
			else if (Yas < 15)
			{
				IndirimliUcrt = Ucret * 50 / 100;

			}
			else
			{
				IndirimliUcrt = Ucret;
			}
		}
	}
}
