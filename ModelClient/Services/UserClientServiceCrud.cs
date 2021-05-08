using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelClient.Mappers;
using ModelClient.Models;
using ModelGlobal.Services;
using VitalTools.Model.Services;

namespace ModelClient.Services
{
	public class UserClientServiceCrud : IServiceModelCRUD<UserClient>
	{
		UserGlobalServiceCrud userGlobalServiceCrud;

		public UserClientServiceCrud(UserGlobalServiceCrud userGlobalServiceCrud)
		{
			this.userGlobalServiceCrud = userGlobalServiceCrud;
		}

		public int Add(UserClient item)
		{
			throw new NotImplementedException();
		}

		public bool Delete(int id)
		{
			throw new NotImplementedException();
		}

		public bool Edit(int id, UserClient item)
		{
			throw new NotImplementedException();
		}

		public UserClient Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<UserClient> GetAll()
		{
			return userGlobalServiceCrud.GetAll().Select(u => u.ToUserClient());
		}
	}
}
