using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlgyak
{
	internal class Kolcsonzes
	{
		string nev;
		char jazon;
		int eOra;
		int ePerc;
		int vÓra;
		int vPerc;
		public Kolcsonzes(string csvSor)
		{
            var mezok = csvSor.Split(';');

            this.nev = mezok[0];
            this.jazon = mezok[1][0];
            this.eOra = int.Parse(mezok[2]);
            this.ePerc = int.Parse(mezok[3]);
            this.vÓra = int.Parse(mezok[4]);
            this.vPerc = int.Parse(mezok[5]);


            Kolcsonzes beolvas = new Kolcsonzes(mezok[0], mezok[1][0], int.Parse(mezok[2]), int.Parse(mezok[3]), int.Parse(mezok[4]), int.Parse(mezok[5]));
        }
		public Kolcsonzes(string nev, char jazon, int eOra, int ePerc, int vÓra, int vPerc )
		{
			this.nev = nev;
			this.jazon = jazon;
			this.eOra = eOra;
			this.ePerc = ePerc;
            this.vÓra = vÓra;
            this.vPerc = vPerc;

		}

		public string Nev { get => nev;}
		public char Jazon { get => jazon;}
		public int EOra { get => eOra; }
		public int EPerc { get => ePerc; }
        public int VÓra { get => vÓra; }
        public int VPerc { get => vPerc; }

    }
}
