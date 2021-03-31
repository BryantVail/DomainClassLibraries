using MedicationDomain.Entities.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicationDomain.Entities
{
	public class Medication
	{

		public int Id { get; set; }
		public TherapeudicClassHierarchy TherapeudicClassHierarchy { get; set; }
		public string Name { get; set; }

		// collections
		public List<Dispense> Dispenses { get; set; }

	}
}
