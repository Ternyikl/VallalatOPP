using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VallalatOPP
{
	internal abstract class Mesterember : IBevetel
	{
		private string nev;
		private int napiDíj;
		protected bool[] foglaltNapok;

		protected Mesterember(string nev, int napiDíj)
		{
			this.nev = nev;
			this.napiDíj = napiDíj;
			this.foglaltNapok = new bool[31];
		}

		public string Nev { get => nev; }
		public int NapiDíj { get => napiDíj; set => napiDíj = value; }
		public bool[] FoglaltNapok { get => foglaltNapok; }

		public abstract bool MunkaVallal(int nap);

		public double HaviBevetel()
		{
			double bevetel = 0;
			foreach(var item in this.foglaltNapok)
			{
				if(item)
				{
					bevetel += napiDíj;
				}
			}

			return bevetel;
		}

		public override string ToString()
		{
			string s = "";

			for (int i = 0; i < this.foglaltNapok.Length; i++)
			{
				s += $"{i}: ";
				s += (this.foglaltNapok[i]) ? "D" : "Sz";
				s += " | ";
			}
			return $"{this.nev} - napidíj: {this.napiDíj} Ft\n{s}\nHavi bevétel: {this.HaviBevetel()}";
		}
	}
}
