using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelGlobal.Mappers;
using ModelGlobal.Models;
using VitalTools.Database;
using VitalTools.Model.Services;

namespace ModelGlobal.Services
{
	public class UserGlobalServiceCrud : IServiceModelCRUD<UserGlobal>
	{
		Connection connection;

		public UserGlobalServiceCrud(Connection connection)
		{
			this.connection = connection;
		}


		public int Add(UserGlobal item)
		{
			throw new NotImplementedException();
		}

		public bool Delete(int id)
		{
			throw new NotImplementedException();
		}

		public bool Edit(int id, UserGlobal item)
		{
			throw new NotImplementedException();
		}

		public UserGlobal Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<UserGlobal> GetAll()
		{
			Command command = new Command("SP_AspUser_GetAll", true);
			return connection.ExecuteReader(command, (dr) => dr.ToUserGlobal());
		}
	}
}