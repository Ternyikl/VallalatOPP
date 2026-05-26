using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VallalatOPP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Burkolo b1 = new Burkolo("Pista", 40000, Helyszin.Külső);
			Burkolo b2 = new Burkolo("Béla", 32000, Helyszin.Belső);
			Console.WriteLine(b1);
			Console.WriteLine(b2);
			b1.MunkaVallal(3);
			b2.MunkaVallal(12);
			Console.WriteLine(b1);
			Console.WriteLine(b1.osszesSzabadnap());
			Console.WriteLine(b2);
			Console.WriteLine(b2.osszesSzabadnap());

			VizvezetekSzerelo v1 = new VizvezetekSzerelo("Géza", 30000, 20);
			VizvezetekSzerelo v2 = new VizvezetekSzerelo("András", 25000, 10);
			Console.WriteLine(v1);
			Console.WriteLine(v2);
			v1.MunkaVallal(2);
			v2.MunkaVallal(5);
			Console.WriteLine(v1);
			Console.WriteLine(v2);

			Fuvarozo f1 = new Fuvarozo("Pista", 1200);
			Console.WriteLine(f1);
			f1.Naplozas(85);
			f1.Naplozas(24);
			f1.Naplozas(33);
			f1.Naplozas(13);
			f1.Naplozas(5);
			Console.WriteLine(f1);

			Console.WriteLine("------------------------------------------------------------------------");

			List<IBevetel> lista = new List<IBevetel> { b1, b2, v1, v2, f1 };

			foreach (var item in lista)
			{
				if(item is Mesterember)
				{
					Console.WriteLine($"{((Mesterember)item).Nev} összes bevétel: {item.HaviBevetel()} Ft");
				}
				else if(item.GetType() == typeof(Fuvarozo))
				{
					Console.WriteLine($"{((Fuvarozo)item).Nev} összes bevétel: {item.HaviBevetel()} Ft");
				}
			}
		}
	}
}
