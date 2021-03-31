using System;
using System.Collections.Generic;
using System.Text;

namespace MedicationDomain.Entities
{
	public class Dispense
	{

		public int Id { get; set; }
		public DateTime DispensedAt { get; set; }
		public CancelledDispense CancelledDispense { get; set; }
		
		// collections
		public List<Prescription> Prescriptions{ get; set; }

	}
}
