using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class GamesAttribute : Attribute {
		private GameFlags flags;
		public GamesAttribute(GameFlags flags) {
			this.flags = flags;
		}
	}
}