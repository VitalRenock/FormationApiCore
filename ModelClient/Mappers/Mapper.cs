using ModelClient.Models;
using ModelGlobal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelClient.Mappers
{
	public static class Mapper
	{
		#region User

		public static UserGlobal ToUserGlobal(this UserClient userClient)
		{
			return new UserGlobal()
			{
				Id = userClient.Id,
				Email = userClient.Email,
				Password = userClient.Password,
				LastName = userClient.LastName,
				FirstName = userClient.FirstName,
				BirthDate = userClient.BirthDate,
				RegNational = userClient.RegNational,
				Bio = userClient.Bio
			};
		}

		public static UserClient ToUserClient(this UserGlobal userGlobal)
		{
			return new UserClient()
			{
				Id = userGlobal.Id,
				Email = userGlobal.Email,
				Password = userGlobal.Password,
				LastName = userGlobal.LastName,
				FirstName = userGlobal.FirstName,
				BirthDate = userGlobal.BirthDate,
				RegNational = userGlobal.RegNational,
				Bio = userGlobal.Bio
			};
		}

		#endregion
	}
}
