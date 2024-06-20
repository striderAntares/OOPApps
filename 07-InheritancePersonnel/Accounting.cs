using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_InheritancePersonnel
{
    internal class Accounting : Human
    {
		private bool _canGetWage;

		public bool CanGetWage
		{
			get { return _canGetWage; }
			set { _canGetWage = value; }
		}

		private bool _canChangeWageInfo;

		public bool CanChangeWageInfo
		{
			get { return _canChangeWageInfo; }
			set { _canChangeWageInfo = value; }
		}


	}


}
