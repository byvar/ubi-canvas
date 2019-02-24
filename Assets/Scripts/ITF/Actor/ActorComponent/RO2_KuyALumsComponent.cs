using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class RO2_KuyALumsComponent : RO2_AIComponent {
		// public bool killed; <- not serialized for files because they're never already killed

		public RO2_KuyALumsComponent(Reader reader) : base(reader) {
		}
	}
}
