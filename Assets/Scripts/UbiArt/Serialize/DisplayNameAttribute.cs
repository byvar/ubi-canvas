using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	[AttributeUsage(AttributeTargets.Field)]
	public class DisplayNameAttribute : Attribute {
		private string displayName;

		public DisplayNameAttribute(string dîsplayName) {
			this.displayName = dîsplayName;
		}
		public string DisplayName => displayName;
	}
}