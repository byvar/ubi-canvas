using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class UnknownComponent1 : ActorComponent {
		[Serialize(0, "type")] public StringID type;
		[Serialize(1, "value")] public int value;

		public UnknownComponent1(Reader reader) : base(reader) {
		}
	}
}
