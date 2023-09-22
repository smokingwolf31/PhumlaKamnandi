using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
	internal class Room
	{
		#region Attributes
		private int roomNumber;
		private int hotelCode;
		private int numberOfOccupants;
		#endregion

		#region Property Methods
		public int RoomNumber{
			set { roomNumber = value; }get { return roomNumber; }
		}
		public int HotelCode { 
			set { hotelCode = value; }get { return hotelCode; }
		}
		public int NumberOfOccupants { 
			set { numberOfOccupants = value; }get { return numberOfOccupants; }
		}
		#endregion

		#region Constuctor
		public Room(int roomNumber, int hotelCode, int numberOfccupants) { 
			this.RoomNumber = roomNumber;
			this.hotelCode = hotelCode;
			this.numberOfOccupants = numberOfccupants;
		}
		#endregion
	}
}
