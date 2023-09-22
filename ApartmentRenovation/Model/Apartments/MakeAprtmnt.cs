using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation.Model.Apartments
{
	internal class MakeAprtmnt
	{
		string name;
		byte type;
		byte livngRm;
		byte ktchn;
		byte bathRm;
		byte room;

		LinkedList<Aprtmnt> aprtmntList = new LinkedList<Aprtmnt>();
		public LinkedList<Aprtmnt> ApartmentCreate()
		{ return aprtmntList; }

		public int AprtmntCreate()
		{
			//Aprtmnt aprt = new Aprtmnt();
			//AprtmntWAddRm aprtRoom = new AprtmntWAddRm();

			Aprtmnt testAprtmnt = new Aprtmnt(name, 1, 1, 2, 1);
			Aprtmnt testAprtmnt2 = new AprtmntWAddRm(name, 3, 2, 1, 1, room);
			Debug.WriteLine("Test Apartment");
			Debug.WriteLine(testAprtmnt.ToString());
			Debug.WriteLine("Test Apartment2");
			Debug.WriteLine(testAprtmnt2.ToString());

			while (true)
			{
                Console.WriteLine("Enter name: ");
				name = Console.ReadLine();
				Console.WriteLine("Enter type: ");
				type = byte.Parse(Console.ReadLine());
                Console.WriteLine("Enter amount of living rooms: ");
				livngRm = byte.Parse(Console.ReadLine());
                Console.WriteLine("Enter amount of kitchens: ");
				ktchn = byte.Parse(Console.ReadLine());
				Console.WriteLine("Enter amount of bathrooms: ");
				bathRm = byte.Parse(Console.ReadLine());
                if (type < 1)
				{
					aprtmntList.AddLast(new AprtmntWAddRm(name, type, livngRm, ktchn, bathRm, room));
				}
				aprtmntList.AddLast(new Aprtmnt(name, type, livngRm, ktchn, bathRm));
            }

		}
	}
}
