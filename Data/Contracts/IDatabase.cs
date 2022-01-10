namespace CQRSWithDapper.Data.Contracts
{
	public interface IDatabase
	{
		T Query<T>(IQuery<T> query);
		void Execute(ICommand command);
	}
}
