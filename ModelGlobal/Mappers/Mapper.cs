using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using ModelGlobal.Models;

namespace ModelGlobal.Mappers
{
	public static class Mapper
	{
		public static UserGlobal ToUserGlobal(this IDataRecord dataRecord)
		{
			return new UserGlobal()
			{
				Id = (int)dataRecord["Id"],
				Email = (string)dataRecord["Email"],
				Password = (string)dataRecord["Password"],
				LastName = (string)dataRecord["LastName"],
				FirstName = (string)dataRecord["FirstName"],
				BirthDate = (DateTime)dataRecord["BirthDate"],
				RegNational = (string)dataRecord["RegNational"],
				Bio = (string)dataRecord["Bio"]
			};
		}
	}
}
