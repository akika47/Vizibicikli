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
		int vOra;
		int vPerc;
		public int IdoHoszz()
		{
			return vOra * 60 + VPerc - (EOra * 60 + ePerc);
		}
		public Kolcsonzes(string nev, char jazon, int eOra, int ePerc, int vOra, int vPerc )
		{
			this.nev = nev;
			this.jazon = jazon;
			this.eOra = eOra;
			this.ePerc = ePerc;
            this.vOra = vOra;
            this.vPerc = vPerc;

		}

		public string Nev { get => nev;}
		public char Jazon { get => jazon;}
		public int EOra { get => eOra; }
		public int EPerc { get => ePerc; }
        public int VOra { get => vOra; }
        public int VPerc { get => vPerc; }

    }
}
