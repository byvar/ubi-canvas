using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	[AttributeUsage(AttributeTargets.Field)]
	public class SerializeAttribute : Attribute {
		private string name;
		public VersionFlags version = VersionFlags.All;
		public SerializeFlags flags = SerializeFlags.None;
		private readonly int order;

		public SerializeAttribute(string name, [CallerLineNumber]int order = 0) {
			this.order = order;
			this.name = name;
		}
		public int Order => order;
		public string Name => name;
	}
}