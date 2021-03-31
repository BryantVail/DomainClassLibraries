using MedicationDomain.Entities.Enums;

namespace MedicationDomain.Entities
{
	public interface IAddress
	{

		public string Street { get; set; }
		public string AddressNumber { get; set; }
		public StreetType StreetType { get; set; }

	}
}