

using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace sqlgyak
{
	internal class Program
	{

		static void Main(string[] args)
		{
			List<Kolcsonzes> kolcsonzesek = new List<Kolcsonzes>();
			StreamReader sr = new StreamReader("Kolcsonzesek.txt");
			sr.ReadLine();
			while (!sr.EndOfStream)
			{
				var mezok = sr.ReadLine().Split(';');
				Kolcsonzes beolvas = new Kolcsonzes(mezok[0], mezok[1][0], int.Parse(mezok[2]), int.Parse(mezok[3]), int.Parse(mezok[4]), int.Parse(mezok[5]));
				kolcsonzesek.Add(beolvas);
			}
			sr.Close();

			//5.feladat
			Console.WriteLine($"5. feladat: Napi kölcsönzések száma: {kolcsonzesek.Count}");
			//6.
			Console.Write("6. feladat: Kérek egy nevet: ");
			string nev = Console.ReadLine();

			Console.WriteLine($"\t{nev} kölcsönzései: ");
			if (kolcsonzesek.Count(x => x.Nev == nev) == 0)
			{
				Console.WriteLine("\tNem volt ilyen nevű kölcsönző");
			}
			else
			{
				kolcsonzesek.Where(x => x.Nev == nev).ToList().ForEach(x => Console.WriteLine($"\t {x.EOra}:{x.EPerc}-{x.VOra}:{x.VPerc}"));

			}
			//7
			Console.Write("7. feladat: Adjon meg egy időpontot:perc alakban: ");
			string ido = Console.ReadLine();
			Console.WriteLine($"\tA vizen lévő járművek: ");
			kolcsonzesek.Where(x => x.BennVanE(ido) == true).ToList().ForEach(x => Console.WriteLine($"\t{x.EOra}:{x.EPerc}-{x.VOra}:{x.VPerc} : {x.Nev}"));


			//8
			int napiBevetel = (kolcsonzesek.Sum(ob => ob.IdoHoszz()) / 30 + 1) * 2400;
			Console.WriteLine($"8. feladat: Napi bevétel: {napiBevetel} Ft");


			//9
			List<Kolcsonzes> elkovetok = kolcsonzesek.Where(x => x.Jazon == 'F').ToList();
			using (StreamWriter wr = new StreamWriter("F.txt"))
			{
                foreach (var item in elkovetok)
                {
					wr.WriteLine($"{item.EOra}:{item.EPerc}-{item.VOra}:{item.VPerc} : {item.Nev}");
                }
            }



            //10
            Console.WriteLine("10. feladat: Statisztika");
			kolcsonzesek.GroupBy(x=>x.Jazon).OrderBy(x => x.Key).ToList().ForEach(x => Console.WriteLine($"\t{x.Key} - {x.Count()}"));
		}
	}
}