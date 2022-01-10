using System.Linq;
using System.Collections.Generic;

using CQRSWithDapper.Core.Enums;
using CQRSWithDapper.Core.Models;
using CQRSWithDapper.Data.Contracts;

namespace CQRSWithDapper.Data.Queries.Animals
{
	public class GetAnimalsByCommonName : IQuery<IList<Animal>>
	{
		private readonly CommonName _commonName;

		public GetAnimalsByCommonName(CommonName commonName)
		{
			_commonName = commonName;
		}

		public IList<Animal> Execute(ISession session)
		{
			return session.Query<Animal>("SELECT * FROM Animals WHERE CommonName = @CommonName", new { CommonName = _commonName }).ToList();
		}
	}
}
