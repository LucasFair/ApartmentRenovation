using ApartmentRenovation.Model.Apartments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation.Controller
{
	internal class RenovationController
	{
		MakeAprtmnt mkAprt = new MakeAprtmnt();
		public void Run()
		{
			mkAprt.AprtmntCreate();
		}

	}
}
