namespace CQRSWithDapper.Data.Contracts
{
	public interface ICommand
	{
		void Execute(ISession session);
	}
}
