using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class PhysComponent : ActorComponent {
		[Serialize(0, "Mass", game = Settings.Game.RA)] public float mass;
		[Serialize(1, "Friction", game = Settings.Game.RA)] public float friction;
		[Serialize(2, "FrictionMultiplier", game = Settings.Game.RA)] public float frictionMultiplier;

		public PhysComponent(Reader reader) : base(reader) {
		}
	}
}
