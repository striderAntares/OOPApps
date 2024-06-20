using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_InheritancePersonnel
{
    internal class TechService : Human
    {
		private bool _canSetNetwork;

		public bool CanSetNetwork
		{
			get { return _canSetNetwork; }
			set { _canSetNetwork = value; }
		}

		private bool _canGiveTechService;

		public bool CanGiveTechService
		{
			get { return _canGiveTechService; }
			set { _canGiveTechService = value; }
		}

		private bool _canPurchaseComp;

		public bool CanPurchaseComp
		{
			get { return _canPurchaseComp; }
			set { _canPurchaseComp = value; }
		}



	}
}
