using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation.Model.Apartments
{
	internal class AprtmntWAddRm : Aprtmnt
	{
		protected private byte _room;

		protected byte Room
		{
			get { return _room; }
			private set { _room = value; }
		}

		protected internal AprtmntWAddRm() 
		{
			_room = 1;
		}
		protected internal AprtmntWAddRm(string name, byte type, byte livngRm, byte ktchn, byte bathRm, byte room) : base()
		{
			_name = name;
			_type = type;
			_livngRm = livngRm;
			_ktchn = ktchn;
			_bathRm = bathRm;
			_room = (byte)(type - 1);
		}

		public override string ToString()
		{
			return $"{base.ToString()}\n" +
				$"Number of additional rooms: {Room}";
		}
	}
}
