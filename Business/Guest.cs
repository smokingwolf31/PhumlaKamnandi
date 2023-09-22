using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandi.Business
{
	internal class Guest : Person
	{
		#region Attributes
		private DateTime dateOfBirth;
		private int roomNumber;
		private int hotelCode;
		#endregion

		#region Property Methds
		public DateTime DateOfBirth { 
			set { dateOfBirth = value; }	get { return dateOfBirth; }
		}
		public int RoomNumber { 
			set { roomNumber = value; } get { return this.roomNumber; }
		}
		public int HotelCode { 
			set { hotelCode = value; } get { return this.hotelCode; }
		}
		#endregion

		#region Constuctor
		public Guest(int id, string firstName, string surname) : base(id, firstName, surname) { }
		public Guest(int Id, string firstName, string surname, DateTime dob, int roomNumber, int hotelCode) : base(Id, firstName, surname) {
			this.dateOfBirth = dob;
			this.roomNumber = roomNumber;
			this.hotelCode = hotelCode;
		}
		#endregion
	}
}
