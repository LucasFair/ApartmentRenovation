using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation.Model.Apartments
{
	public class IAprtmntEx
	{
		interface ApartmentInterface
		{
			bool _newFloor
			{ get; set; }
			bool _newKtchn
			{ get; set; }
			bool _renovBathRm
			{ get; set; }
			bool _newFntDoor
			{ get; set; }
			bool _newBckDoor
			{ get; set; }
			bool _newWindow
			{ get; set; }
			decimal _price  // Decimal is more resource intensive than double,
							// but usually used for money. For speed, double would
							// be better, or even less precision with a float
			{ get; set; }
			short _aprtAmnt  // The amount of apartments available
			{ get; set; }
		}
	}
}
