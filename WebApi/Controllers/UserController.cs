using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using ModelClient.Services;

namespace WebApi.Controllers
{
	public class UserController : ControllerBase
	{
		UserClientServiceCrud userClientServiceCrud;

		public UserController(UserClientServiceCrud userClientServiceCrud)
		{
			this.userClientServiceCrud = userClientServiceCrud;
		}

		public IEnumerable<UserClient>
	}
}
