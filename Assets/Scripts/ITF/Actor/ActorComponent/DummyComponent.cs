using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class DummyComponent : ActorComponent {
		[Serialize(0, "is2D", game = Settings.Game.RA)] public bool is2D;

		public DummyComponent(Reader reader) : base(reader) {
		}
	}
}
