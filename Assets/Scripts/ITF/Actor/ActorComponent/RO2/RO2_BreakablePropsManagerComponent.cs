using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class RO2_BreakablePropsManagerComponent : ActorComponent {
		[Serialize(0, "lumsGiven")] public uint lumsGiven;
		[Serialize(1, "lumsDrcGiven")] public uint lumsDrcGiven;

		public RO2_BreakablePropsManagerComponent(Reader reader) : base(reader) {
		}
	}
}
