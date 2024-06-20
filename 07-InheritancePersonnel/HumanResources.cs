using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_InheritancePersonnel
{
    internal class HumanResources : Human
    {
		private bool _canHire;

		public bool CanHire
		{
			get { return _canHire; }
			set { _canHire = value; }
		}

		private bool _canSetWage;

		public bool CanSetWage
		{
			get { return _canSetWage; }
			set { _canSetWage = value; }
		}

		private bool _canSetWorkingHour;

		public bool CanSetWorkingHour
		{
			get { return _canSetWorkingHour; }
			set { _canSetWorkingHour = value; }
		}

		public HumanResources(string nameSurnamee, DateTime dt, bool sex, bool driversLicense, byte weight, float height, bool healthIssues, decimal wage, bool canSetWH, bool canSW, bool canHire)
		{ 
			Birthdate = dt;
			NameSurname = nameSurnamee;
			Sex = sex;
			DriversLicense = driversLicense;
			Weight = weight;
			Height = height;
			HealthIssues = healthIssues;
			Wage = wage;
			CanSetWage = canSetWH;
			CanSetWorkingHour = canSW;
			CanHire = canHire;

            Console.WriteLine($"{NameSurname} of HR personnel:\nBirthdate: {Birthdate.ToShortDateString()}" +
                $"\nSex: {(Sex ? "Male" : "Female")}" +
                $"\nWeight: {Weight} KG" +
                $"\nHeight: {Height} CM" +
                $"\nDrivers License: {(DriversLicense ? "Yes" : "No")}" +
                $"\nSağlık Sorunu: {(HealthIssues ? "Yes" : "No")}" +
                $"\nWage: {Wage} TL" +
                $"\n\nPowers:" +
                $"\nCan Hire: {(CanHire ? "Yes" : "No")}" +
                $"\nCan set wage: {(CanSetWage ? "Yes" : "No")}" +
                $"\nCan set working hour {(CanSetWorkingHour ? "Yes" : "No")}");
        }

		public void GetInfor()
		{
            Console.WriteLine($"{NameSurname} of HR personnel:\nBirthdate: {Birthdate.ToShortDateString()}" +
                $"\nSex: {(Sex ? "Male" : "Female")}" +
                $"\nWeight: {Weight} KG" +
                $"\nHeight: {Height} CM" +
                $"\nDrivers License: {(DriversLicense ? "Yes" : "No")}" +
                $"\nHealth Issues: {(HealthIssues ? "Yes" : "No")}" +
                $"\nWage: {Wage} TL" +
                $"\n\nPowers:" +
                $"\nCan Hire: {(CanHire ? "Yes" : "No")}" +
                $"\nCan set wage: {(CanSetWage ? "Yes" : "No")}" +
                $"\nCan set working hour {(CanSetWorkingHour ? "Yes" : "No")}");
        }



	}
}
