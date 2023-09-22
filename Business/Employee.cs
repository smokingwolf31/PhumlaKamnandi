using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
	internal class Employee : Person
	{
		#region Attributes
		private int employeeID;
		private string address;
		private string phone;
		private int role;
		private int hotelCode;
		#endregion

		#region Property Methods
		public int EmployeeID { 
			get { return employeeID; } set {  employeeID = value; }
		}
		public string Address { 
			get { return address; } set {  address = value; }
		}
		public string Phone { 
			get { return phone; }set { phone = value; }
		}
		public int Role { 
			get { return role; } set {  role = value; }
		}
		public int HotelCode { 
			get { return hotelCode; } set { hotelCode = value; }
		}
		#endregion

		#region Constuctor
		public Employee(int id, string firstName, string surname) : base(id, firstName, surname){ }
		public Employee(int Id, string firstName, string surname, string address, string phone, int role, int hotelCode, int empID) : base(Id,firstName,surname)
		{
			this.employeeID = empID;
			this.address = address;
			this.phone = phone;
			this.role = role;
			this.hotelCode = hotelCode;
		}
		#endregion
	}
}
