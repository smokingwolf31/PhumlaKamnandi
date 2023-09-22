using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandi.Business
{
	internal class Reservation
	{
		#region Attributes
		private int reservationID;
		private int roomNumber;
		private int hotelCode;
		private int price;
		private DateTimePicker startDate;
		private DateTimePicker endDate;
		private int customerID;   // the person who is making the booking 
		private int employeeID;   // the employee who made the booking on behalf of the customer
		#endregion

		#region Property Methods
		public int ReservationID { 
			set { reservationID = value; }get { return reservationID; }
		}
		public int RoomNumber {
			set { roomNumber = value; } get { return roomNumber; }
		}
		public int HotelCode { 
			set { hotelCode = value; } get { return hotelCode; }
		}
		public int Price {
			set { price = value; } get { return price; }
		}
		public DateTimePicker StartDate { 
			set { startDate = value; } get { return startDate; }
		}
		public DateTimePicker EndDate {
			set { endDate = value; } get { return endDate; }
		}
		public int CustomerID {
			set { customerID = value; } get { return customerID; }
		}
		public int EmployeeID {
			set { employeeID = value; } get { return employeeID; }
		}
		#endregion

		#region Constuctor 
		public Reservation(int resID, int roomNum, int hotelCode, int price, DateTimePicker sDate, DateTimePicker eDate, int cusID, int empId)
		{
			reservationID = resID;
			roomNumber = roomNum;
			this.hotelCode = hotelCode;
			this.price = price;
			startDate = sDate;
			endDate = eDate;
			customerID = cusID;
			employeeID = empId;
		}
		#endregion

	}
}
