using CQRSWithDapper.Core.Enums;

namespace CQRSWithDapper.Core.Models
{
	public class Animal : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public CommonName CommonName { get; set; }
	}
}
