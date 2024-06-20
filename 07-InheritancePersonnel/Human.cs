using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_InheritancePersonnel
{
    internal abstract class Human //we set it to abstract because we don't want to create an object from it. we derived personnel from it it doesn't suit our purposes. all personnel are human but not all human are personnel.
    {
		private string _nameSurname;

		public string NameSurname
		{
			get { return _nameSurname; }
			set { _nameSurname = value; }
		}

		private DateTime _birthDate;

		public DateTime Birthdate
		{
			get { return _birthDate; }
			set { _birthDate = value; }
		}

		private bool _sex;

		public bool Sex
		{
			get { return _sex; }
			set { _sex = value; }
		}

		private byte _weight;

		public byte Weight
		{
			get { return _weight; }
			set { _weight = value; }
		}
		private float _height;

		public float Height
		{
			get { return _height; }
			set { _height = value; }
		}

		private bool _driversLicense;

		public bool DriversLicense
		{
			get { return _driversLicense; }
			set { _driversLicense = value; }
		}

		private bool _healthIssues;

		public bool HealthIssues
		{
			get { return _healthIssues; }
			set { _healthIssues = value; }
		}

		private decimal _wage;

		public decimal Wage
		{
			get { return _wage; }
			set { _wage = value; }
		}








	}
}
