using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation.Model.Apartments
{
	internal class Aprtmnt : IAprtmntEx
	{
		protected private string _name;
		protected private byte _type;
		protected private byte _livngRm;
		protected private byte _ktchn;
		protected private byte _bathRm;

		protected string Name
		{
			get { return _name; }
			private set { _name = value; }
		}
		protected byte Type
		{
			get { return _type; }
			private set { _type = value; }
		}
		protected byte LivngRm
		{
			get { return _livngRm; }
			private set { _livngRm = value; }
		}
		protected byte Ktchn
		{
			get { return _ktchn; }
			private set { _ktchn = value; }
		}
		protected byte BathRm
		{
			get { return _bathRm; }
			private set { _bathRm = value; }
		}

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

		protected internal Aprtmnt()
		{
			_name = "Apartment";
			_type = 0;
			_livngRm = 0;
			_ktchn = 0;
			_bathRm = 0;
			_newFloor = false;
			_newKtchn = false;
			_newFntDoor = false;
			_newBckDoor = false;
			_newWindow = false;
			_price = 0;
			_aprtAmnt = 0;
		}

		internal Aprtmnt(string name, byte type, byte livngRm, byte ktchn, byte bathRm)
		{
			_name = name;
			_type = type;
			_livngRm = livngRm;
			_ktchn = ktchn;
			_bathRm = bathRm;
		}

		public override string ToString()
		{
			return $"[{Name}]" +
				$"Apartment type: {Type}\n" +
				$"Number of living rooms: {LivngRm}\n" +
				$"Number of kitchens: {Ktchn}\n" +
				$"Number of bathrooms: {BathRm}";
		}
	}
}
