using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zero.DomainModel
{
	class School : BaseEntity
	{
		public int Code { get; set; }
		public string Name { get; set; }
		public virtual Address Address { get; set; }

	}
}
