using System;
using System.Collections.Generic;
using System.Text;

namespace ModelGlobal.Models
{
	public class UserGlobal
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public DateTime BirthDate { get; set; }
		public string RegNational { get; set; }
		public string Bio { get; set; }
	}
}
