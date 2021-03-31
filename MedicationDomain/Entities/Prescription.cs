using System.Collections.Generic;

namespace MedicationDomain.Entities
{
	public class Prescription
	{

		public Medication Medication { get; set; }
		public IPatient Patient { get; set; }

		// collections
		public List<Fill> Fills { get; set; }


	}
}