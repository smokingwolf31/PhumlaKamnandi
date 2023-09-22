using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
	internal class Hotel
	{
		#region Attributes
		private int hotelCode;
		private string hotelName;
		private string hotelAddress;
		private string hotelTelephone;
		#endregion

		#region Property Methods
		public int HotelCode { 
			set { hotelCode = value; }get { return hotelCode; }
		}
		public string HotelName { 
			set { hotelName = value; }get { return hotelName; }
		}
		public string HotelAddress { 
			set { hotelAddress = value; } get { return hotelAddress; }
		}
		public string HotelTelephone { 
			set { hotelTelephone = value; } get { return hotelTelephone; }
		}
		#endregion

		#region Constuctor
		public Hotel(int hotelCode, string hotelName, string hotelAddress, string hotelTelephone){
			this.hotelCode = hotelCode;
			this.hotelName = hotelName;
			this.hotelAddress = hotelAddress;
			this.hotelTelephone = hotelTelephone;
		}
		#endregion
	}
}
