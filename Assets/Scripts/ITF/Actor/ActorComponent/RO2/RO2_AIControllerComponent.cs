using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class RO2_GroundAIControllerComponent : GroundAIControllerComponent {
		[Serialize(0, "canDrown", game = Settings.Game.RA)] public bool canDrown;

		public RO2_GroundAIControllerComponent(Reader reader) : base(reader) {
		}
	}
}
