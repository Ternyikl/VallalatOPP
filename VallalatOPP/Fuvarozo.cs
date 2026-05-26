using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VallalatOPP
{
	internal class Fuvarozo : IBevetel
	{
		private string nev;
		private int kilometerDij;
		private List<int> megtettKilometer;

		public Fuvarozo(string nev, int kilometerDij)
		{
			this.nev = nev;
			this.kilometerDij = kilometerDij;
			this.megtettKilometer = new List<int>();
		}

		public string Nev { get => nev; }
		public int KilometerDij { get => kilometerDij; set => kilometerDij = value; }
		public List<int> MegtettKilometer { get => megtettKilometer; }

		public double HaviBevetel()
		{ 
			return this.megtettKilometer.Sum() * this.kilometerDij;
		}

		public void Naplozas(int kilometer)
		{
			this.megtettKilometer.Add(kilometer);
		}

		public override string ToString()
		{
			return $"Fuvarozó: {this.nev} - {this.kilometerDij} Ft\nMegtett kilóméter a hónapban: {megtettKilometer.Sum()} - Havi bevétel: {this.HaviBevetel()}";
		}
	}
}
