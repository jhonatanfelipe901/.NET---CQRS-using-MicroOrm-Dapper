using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSWithDapper.Core
{
	public interface IEntity
	{
		int Id { get; set; }
	}
}
