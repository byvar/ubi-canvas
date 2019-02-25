using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class StickToPolylinePhysComponent : PhysComponent {
		[Serialize(0, "ForceVerticalBanking", game = Settings.Game.RA)] public bool ForceVerticalBanking;
		[Serialize(1, "IgnoreAngle", game = Settings.Game.RA)] public bool IgnoreAngle;
		[Serialize(2, "StartDisable", game = Settings.Game.RA)] public bool StartDisable;

		public StickToPolylinePhysComponent(Reader reader) : base(reader) {
		}
	}
}
