using CQRSWithDapper.Core.Models;
using CQRSWithDapper.Data.Contracts;

namespace CQRSWithDapper.Data.Commands.Animals
{
	public class SaveAnimalCommand : ICommand
	{
		private readonly Animal _animal;

		public SaveAnimalCommand(Animal animal)
		{
			_animal = animal;
		}

		public void Execute(ISession session)
		{
			if (_animal.Id > 0)
			{
				session.Execute("UPDATE Animals SET Name = @Name, CommonName = @CommonName WHERE Id = @Id", new { _animal.Id, _animal.Name, _animal.CommonName });
				return;
			}

			session.Execute("INSERT INTO Animals (Name, CommonName) VALUES (@Name, @CommonName)", new { _animal.Name, _animal.CommonName });
		}
	}
}
