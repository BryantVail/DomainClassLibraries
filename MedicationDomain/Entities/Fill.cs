using System;
using System.Collections.Generic;
using System.Text;

namespace MedicationDomain.Entities
{
	public class Fill
	{

		public int Id { get; set; }
		public int FillNumber { get; set; }
		public DateTime FilledAt { get; set; }
		public Pharmacy Pharmacy { get; set; }

	}
}
