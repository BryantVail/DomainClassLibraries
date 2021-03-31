using System;
using System.Collections.Generic;

namespace MedicationDomain.Entities
{
#nullable enable
	public class CancelledDispense 
	{

		public int Id { get; set; }
		public DateTime TimeStamp { get; set; }
		public string Reason { get; set; }
		public List<string> Notes { get; set; }

	}
}