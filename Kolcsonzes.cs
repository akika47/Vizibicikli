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

			return vOra * 60 + vPerc - (eOra * 60 + ePerc);
		}
		public bool BennVanE(string idopont)
		{
			int ora = int.Parse(idopont.Split(':')[0]);
			int perc = int.Parse(idopont.Split(':')[1]);
			int ido = ora*60 + perc;
			int kezdoido = eOra * 60 + ePerc;
			int vegzoido = vOra * 60 + vPerc;
			if (kezdoido <= ido && vegzoido >= ido)
			{
				return true;
			}
			else { return false; }
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
