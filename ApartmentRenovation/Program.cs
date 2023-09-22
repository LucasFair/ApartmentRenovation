using ApartmentRenovation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			RenovationController renoCtrl = new RenovationController();
			renoCtrl.Run();
		}
	}
}
