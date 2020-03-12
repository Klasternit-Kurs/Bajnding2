using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bajnding2
{
	public class Osoba
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public int Godine { get; set; }

		public Osoba (string i, string p)
		{
			Ime = i;
			Prezime = p;
		}
	}
}
