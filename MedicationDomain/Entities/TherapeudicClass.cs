using System;
using System.Collections.Generic;
using System.Text;

namespace MedicationDomain.Entities
{
	public class TherapeudicClass 
	{

		public TherapeudicClass() { }

		public TherapeudicClass(TherapeudicClass therapeudicClass)
		{
			this.Id = therapeudicClass.Id;
			this.Name = therapeudicClass.Name;
			this.Description = therapeudicClass.Description;
		}


		public int Id { get; set; }
		public TherapeudicClass? Parent { get; set; }
		public TherapeudicClass? Child { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }



	}
}
