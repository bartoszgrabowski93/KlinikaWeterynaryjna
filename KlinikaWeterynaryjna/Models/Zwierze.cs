using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaWeterynaryjna.Models
{
    internal class Zwierze
    {
		private int _idZwierze;

		public int IdZwierze
		{
			get { return _idZwierze; }
			set { _idZwierze = value; }
		}

		private string _nazwa;

		public string Nazwa
		{
			get { return _nazwa; }
			set { _nazwa = value; }
		}

		private string _gatunek;

		public string Gatunek
		{
			get { return _gatunek; }
			set { _gatunek = value; }
		}

		private string _dataOstatniejWizyty;

		public string DataOstatniejWizyty
		{
			get { return _dataOstatniejWizyty; }
			set { _dataOstatniejWizyty = value; }
		}

		private int _idWlasciciel;

		public int IdWlasciciel
		{
			get { return _idWlasciciel; }
			set { _idWlasciciel = value; }
		}


	}
}
