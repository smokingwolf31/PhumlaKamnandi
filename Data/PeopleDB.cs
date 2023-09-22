using PhumlaKamnandi.Business;
using PhumlaKamnandi.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhumlaKamnandi.Business;

namespace WaiteringSystem.Data
{
	public class PeopleDB : DB
	{
		#region  Data members        
		private string table1 = "Customers";
		private string sqlLocal1 = "SELECT * FROM Customers";
		private string table2 = "Guests";
		private string sqlLocal2 = "SELECT * FROM Guests";
		private string table3 = "Employees";
		private string sqlLocal3 = "SELECT * FROM Employees";
		private Collection<Customer> customers;
		private Collection<Guest> guests;
		private Collection<Employee> employees;

		#endregion

		#region Property Method: Collection
		public Collection<Customer> AllCustomers {
			get { return customers; }
		}

		public Collection<Guest> AllGuest {
			get { return guests; }
		}

		public Collection<Employee> AllEmployees
		{
			get {return employees; }
		}

		#endregion

		#region Constructor
		public PeopleDB() : base()
		{
			customers = new Collection<Customer>();
			guests = new Collection<Guest>();
			employees = new Collection<Employee>();
			FillDataSet(sqlLocal1, table1);
			Add2Collection(table1);
			FillDataSet(sqlLocal2, table2);
			Add2Collection(table2);
			FillDataSet(sqlLocal3, table3);
			Add2Collection(table3);
		}
		#endregion

		#region Utility Methods
		public DataSet GetDataSet()
		{
			return dsMain;
		}
		private void Add2Collection(string table)
		{
			//Declare references to a myRow object and an Employee object
			DataRow myRow = null;
			Customer customer;
			Guest guest;
			Employee employee;
			//READ from the table  
			foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
			{
				myRow = myRow_loopVariable;
				if (!(myRow.RowState == DataRowState.Deleted))
				{
					int id = Convert.ToInt32(myRow["Id"]);
					string firstName = Convert.ToString(myRow["FirstName"]).TrimEnd();
					string surname = Convert.ToString(myRow["Surname"]).TrimEnd();
					switch (table) {
						case "Customers":
							customer = new Customer(id, firstName, surname);
							customer.Address = Convert.ToString(myRow["Address"]).TrimEnd();
							customer.DateOfBirth = Convert.ToDateTime(myRow["DateOfBirth"]);
							customer.Phone = Convert.ToString(myRow["Phone"]).TrimEnd();
							customer.AccountNumber = Convert.ToInt32(myRow["AccountNumber"]);
							customers.Add(customer);
							break;
						case "Guests":
							guest = new Guest(id, firstName, surname);
							guest.DateOfBirth = Convert.ToDateTime(myRow["DateOfBirth"]);
							guest.RoomNumber = Convert.ToInt32(myRow["RoomNumber"]);
							guest.HotelCode = Convert.ToInt32(myRow["HotelCode"]);
							guests.Add(guest);
							break;
						case "Employees":
							employee = new Employee(id, firstName, surname);
							employee.Address = Convert.ToString(myRow["Address"]).TrimEnd();
							employee.Phone = Convert.ToString(myRow["Phone"]).TrimEnd();
							employee.Role = Convert.ToInt32(myRow["Role"]);
							employee.HotelCode = Convert.ToInt32(myRow["HotelCode"]);
							employees.Add(employee);
							break;
					}
				}
			}
		}
		private void FillRow(DataRow aRow, Customer customer)
		{
			aRow["Id"] = customer.ID;
			aRow["FirstName"] = customer.FirstName;
			aRow["Surname"] = customer.Surname;
			aRow["Address"] = customer.Address;
			aRow["DateOfBirth"] = customer.DateOfBirth;
			aRow["Phone"] = customer.Phone;
			aRow["AccountNumber"] = customer.AccountNumber;
		}
		private void FillRow(DataRow aRow, Guest guest)
		{
			aRow["Id"] = guest.ID;
			aRow["FirstName"] = guest.FirstName;
			aRow["Surname"] = guest.Surname;
			aRow["DateOfBirth"] = guest.DateOfBirth;
			aRow["HotelCode"] = guest.HotelCode;
			aRow["RoomNumber"] = guest.RoomNumber;
		}
		private void FillRow(DataRow aRow, Employee employee)
		{
			aRow["Id"] = employee.ID;
			aRow["FirstName"] = employee.FirstName;
			aRow["Surname"] = employee.Surname;
			aRow["Address"] = employee.Address;
			aRow["Phone"] = employee.Phone;
			aRow["Role"] = employee.Role;
			aRow["HotelCode"] = employee.HotelCode;
		}
		#endregion

		#region Database Operations CRUD
		public void DataSetChange(Customer customer)
		{
			DataRow aRow = null;
			aRow = dsMain.Tables[table1].NewRow();
			FillRow(aRow, customer);
			//Add to the dataset
			dsMain.Tables[table1].Rows.Add(aRow);
		}
		public void DataSetChange(Guest guest)
		{
			DataRow aRow = null;
			aRow = dsMain.Tables[table1].NewRow();
			FillRow(aRow, guest);
			//Add to the dataset
			dsMain.Tables[table1].Rows.Add(aRow);
		}
		public void DataSetChange(Employee anEmp)
		{
			DataRow aRow = null;
			aRow = dsMain.Tables[dataTable].NewRow();
			FillRow(aRow, anEmp);
			//Add to the dataset
			dsMain.Tables[dataTable].Rows.Add(aRow);
		}
		#endregion
	}


}
