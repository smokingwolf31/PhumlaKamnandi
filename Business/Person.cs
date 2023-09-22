using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
	internal abstract class Person
	{
		#region Attributes
		private int Id;
		private string firstName;
		private string surname;
		#endregion

		#region Property Methods
		public int ID { 
			set { Id = value; } get { return Id; }
		}
		public string FirstName { 
			set { FirstName = value; } get { return FirstName; }
		}
		public string Surname { 
			set { Surname = value; } get { return Surname; }
		}
		#endregion

		#region Constuctor
		public Person() { }

		public Person(int Id, string firstName, string surname) { 
			this.Id = Id;
			this.firstName = firstName;
			this.surname = surname;
		}
		#endregion
	}
}
