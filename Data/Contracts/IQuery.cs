namespace CQRSWithDapper.Data.Contracts
{
	public interface IQuery<out T>
	{
		T Execute(ISession session);
	}
}
