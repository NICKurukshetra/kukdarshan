using System;
using System.Configuration;

namespace DeafDumb
{
	internal class connection
	{
		public string connectionstring;

		public connection()
		{
			this.connectionstring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
		}
	}
}