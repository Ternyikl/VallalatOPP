using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VallalatOPP
{
	internal class VizvezetekSzerelo : Mesterember
	{
		private int tapasztalat;

		public VizvezetekSzerelo(string nev, int napiDíj, int tapasztalat) : base(nev, napiDíj)
		{
			this.tapasztalat = tapasztalat;
		}

		public override bool MunkaVallal(int nap)
		{
			bool ki = false;
			if (!this.foglaltNapok[nap - 2] && !this.foglaltNapok[nap] && !this.foglaltNapok[nap - 1])
			{
				this.foglaltNapok[nap] = true;
				this.foglaltNapok[nap - 1] = true;
				this.foglaltNapok[nap - 2] = true;
				ki = true;
			}
			return ki;
		}

		public override string ToString()
		{
			return $"Vízvezeték szerelő ({this.tapasztalat} év tapasztalat): {base.ToString()}";
		}
	}
}
