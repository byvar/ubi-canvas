using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class GroundAIControllerComponent : BaseAIControllerComponent {
		[Serialize(0, "AppearDisablePhysic", game = Settings.Game.RA)] public bool appearDisablePhysic;

		public GroundAIControllerComponent(Reader reader) : base(reader) {
		}
	}
}
