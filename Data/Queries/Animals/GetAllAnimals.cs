using CQRSWithDapper.Core.Models;
using CQRSWithDapper.Data.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace CQRSWithDapper.Data.Queries.Animals
{
	public class GetAllAnimals : IQuery<IList<Animal>>
	{
		public IList<Animal> Execute(ISession session)
		{
			return session.Query<Animal>("SELECT * FROM Animals").ToList();
		}
	}
}
