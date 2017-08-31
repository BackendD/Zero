using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zero.DomainModel
{
	class Person : BaseEntity
	{
		public string NationalID { get; set; }
		public string Login { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Role { get; set; }
		public byte[] Photo { get; set; }
		public virtual Address Address { get; set; }

	}
}
