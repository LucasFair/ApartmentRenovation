using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ApartmentRenovation.View
{
	internal class AprtmntCreationView
	{
		public void AprtCreateDiag(int aprtDiagSwitch)
		{
			switch (aprtDiagSwitch)
			{
				case 0:
					Console.WriteLine("Enter name: ");
					break;
				case 1:
					Console.WriteLine("Enter type: ");
					break;
				case 2:
					Console.WriteLine("Enter amount of living rooms: ");
					break;
				case 3:
					Console.WriteLine("Enter amount of kitchens: ");
					break;
				case 4:
					Console.WriteLine("Enter amount of bathrooms: ");
					break;
				default:
					throw new Exception("Something went wrong in the Apartment Creation Console Dialog code.");
			}
		}
		public string NameIn(string name)
		{
			return name = Console.ReadLine();
		}
		public byte ByteIn(byte aprtDiagSwitch, byte type, byte livngRm, byte ktchn, byte bathRm)
		{
			switch (aprtDiagSwitch)
			{
				case 0: return type = byte.Parse(Console.ReadLine());
				case 1: return livngRm = byte.Parse(Console.ReadLine());
				case 2: return ktchn = byte.Parse(Console.ReadLine());
				case 3: return bathRm = byte.Parse(Console.ReadLine());


			}




		}


	}
}
