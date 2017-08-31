using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zero.DomainModel
{
	public class Address : BaseEntity
	{
		public string Country { get; set; }
		public string State { get; set; }
		public string County { get; set; }
		public string CityOrVillage { get; set; }
		public string Street { get; set; }
		public string Detail { get; set; }
		public long PostalCode { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public override string ToString()
		{
			return Latitude + " , " + Longitude;
		}
		public string FullAddress
		{
			get
			{
				return string.Format("{0} - {1} - {2} - {3} - {4} - {5}",
				  Country,
				  State,
				  County,
				  CityOrVillage,
				  Street,
				  Detail);
			}
		}
	}
}
