namespace MedicationDomain.Entities
{
	public class Pharmacy
	{

		public int Id { get; set; }
		public string Name { get; set; }
		public IAddress PhysicalAddress { get; set; }

	}
}