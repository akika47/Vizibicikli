

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
			if (kolcsonzesek.Count(x=> x.Nev == "Kata") == 0)
			{
                Console.WriteLine("Newm volt ilyen nevű kölcsönző");
            }
			else
			{
				kolcsonzesek.Where(x => x.Nev == "Kata").ToList().ForEach(x => Console.WriteLine($"\t {x.EOra}:{x.EPerc}-{x.VOra}:{x.VPerc}"));

            }
			//7
			Console.Write("7. feladat: Adjon meg egy időpontot:perc alakban: ");
	
			string ido = Console.ReadLine();


			//8
			int napiBevetel = kolcsonzesek.Sum(ob => ob.IdoHoszz()) / 30 + 1;
			Console.Write($"8. feladat: Napi bevétel: {napiBevetel} Ft");


			//9


			//10
			kolcsonzesek.GroupBy(x=>x.Jazon).OrderBy(x => x.Key).ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Count()}"));
		}
	}
}