using System;
using System.Collections.Generic;
using System.Text;
using VailSummit.System.Collections.Generic.Derivatives.LinkedList;

namespace MedicationDomain.Entities.Collections
{
	public class TherapeudicClassHierarchy : Hierarchy<TherapeudicClass>
	{

		public TherapeudicClassHierarchy(IEnumerable<TherapeudicClass> list) 
			: base(list)
		{

		}

		public TherapeudicClassHierarchy(string[] list)
		{

			for(uint i = 0; i < list.Length; i++)
			{
				this.AddLast(new LinkedListNode<TherapeudicClass>(
					new TherapeudicClass
					{
						Id = 100000 + (int)i,
						Name = list[i],

					}));

				if(i == 0)
				{
					this.Last.Value.Parent = null;
				}
				else
				{

					this.Last.Value.Parent = this.Last.Previous.Value;
					this.Last.Previous.Value.Child = this.Last.Value;

				}
					
			}
		}

		public string GetNames()
		{
			return GetNames(',');
		}

		public string GetNames(char delimiter)
		{

			string returnValue = "";

			var item = this.First;
			int counter = 1;
			while (true)
			{

				returnValue += $"{item.Value.Name}{delimiter} ";
				counter++;

				if (item.Next != null)
					item = item.Next;
				else
				{
					break;
				}
			}

			return returnValue;

		}

	}
}
