using System;
using System.Data;

namespace CQRSWithDapper.Data.Contracts
{
	public interface IDapperContext : IDisposable
	{
		IDbConnection Connection { get; }
		T Transaction<T>(Func<IDbTransaction, T> query);
		IDbTransaction BeginTransaction();
		void Commit();
		void Rollback();
	}
}
