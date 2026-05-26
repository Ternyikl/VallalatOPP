using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VallalatOPP
{
	enum Helyszin
	{
		Külső, Belső
	}

	internal class Burkolo : Mesterember
	{
		private Helyszin szakterulet;

		public Burkolo(string nev, int napiDíj, Helyszin helyszin) : base(nev, napiDíj)
		{
			this.szakterulet = helyszin;
		}

		public int osszesSzabadnap()
		{
			int szabadnapok = 0;

			foreach(var item in this.foglaltNapok)
			{
				if(!item)
				{
					szabadnapok++;
				}
			}

			return szabadnapok;
		}

		public override bool MunkaVallal(int nap)
		{
			bool ki = false;
			if (!this.foglaltNapok[nap - 1])
			{
				this.foglaltNapok[nap - 1] = true;
				ki = true;
			}
			return ki;
		}

		public override string ToString()
		{
			return $"{this.szakterulet} burkoló: {base.ToString()}";
		}
	}
}
