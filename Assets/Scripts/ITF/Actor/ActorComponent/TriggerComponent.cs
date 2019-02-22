using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class TriggerComponent : ActorComponent {
		[Serialize(0, "mode")] public Mode mode;
		public TriggerComponent(Reader reader) : base(reader) {
		}

		public enum Mode {
			Once = 1,
			OnceAndRetrigger,
			Mode_OnceAndReset,
			Multiple
		}
	}
}
