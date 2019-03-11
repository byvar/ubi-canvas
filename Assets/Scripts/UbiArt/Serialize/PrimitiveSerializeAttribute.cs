using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	[AttributeUsage(AttributeTargets.Field)]
	public class PrimitiveSerializeAttribute : Attribute {
		public Func<bool> condition;
		public SerializeFlags flags = SerializeFlags.None;
		private readonly int order;

		public PrimitiveSerializeAttribute([CallerLineNumber]int order = 0) {
			this.order = order;
		}
		public int Order => order;
	}
}