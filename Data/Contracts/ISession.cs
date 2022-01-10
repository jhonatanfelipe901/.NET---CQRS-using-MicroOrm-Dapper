using System.Collections.Generic;

namespace CQRSWithDapper.Data.Contracts
{
	public interface ISession
	{
		IEnumerable<T> Query<T>(string query, object param = null);
		void Execute(string query, object param = null);
	}
}
