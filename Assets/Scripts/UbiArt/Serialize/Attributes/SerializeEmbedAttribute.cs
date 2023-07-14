using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class SerializeEmbedAttribute : Attribute {
		public SerializeEmbedAttribute() {
		}
	}
}