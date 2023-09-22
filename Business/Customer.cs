using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandi.Business
{
	internal class Customer : Person
	{
		#region Attributes
		private DateTime dateOfBirth;
		private string address;
		private string phone;
		private string email;
		private int accountNumber;
		#endregion

		#region Property Methods
		public DateTime DateOfBirth { 
			set { this.dateOfBirth = value; }	get { return this.dateOfBirth; }
		}
		public string Address { 
			set { this.address = value; } get { return this.address; }
		}
		public string Phone { 
			set { this.phone = value; } get { return this.phone; }
		}
		public string Email { 
			set { this.email = value; } get { return this.email; }
		}
		public int AccountNumber { 
			set { this.accountNumber = value; } get { return this.accountNumber; }
		}
		#endregion

		#region Constuctor
		public Customer(int id, string firstName, string surname) : base(id, firstName, surname) { }
		public Customer(int Id, string firstName, string surname, DateTime dateOfBirth, string email, string phone, int accountNumber) : base(Id, firstName, surname) { 
			this.dateOfBirth = dateOfBirth;
			this.phone = phone;
			this.email = email;
			this.accountNumber = accountNumber;
		}
		#endregion
	}
}
