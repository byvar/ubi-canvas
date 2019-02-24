using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class AIComponent : ActorComponent {
		// public int health; <-- persistent, not serialized

		public AIComponent(Reader reader) : base(reader) {
		}
	}
}
