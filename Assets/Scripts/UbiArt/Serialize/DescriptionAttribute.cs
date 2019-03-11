using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	[AttributeUsage(AttributeTargets.Field)]
	public class DescriptionAttribute : Attribute {
		private string description;

		public DescriptionAttribute(string description) {
			this.description = description;
		}
		public string Description => description;
	}
}