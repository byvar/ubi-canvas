using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class RO2_PrisonerCageComponent : RO2_AIComponent {
		[Serialize(0, "shape")] public EditableShape shape;
		[Serialize(1, "savePosOnCheckpoint")] public bool savePosOnCheckpoint;
		[Serialize(2, "canTriggerMagnet", game = Settings.Game.RA)] public bool canTriggerMagnet;

		public RO2_PrisonerCageComponent(Reader reader) : base(reader) {
		}
	}
}
