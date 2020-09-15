using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class WindComponent_Template : PhysForceModifierComponent_Template {
		public CList<PhysForceModifier> windAreasOrigins;
		public CList<Generic<PhysForceModifier_Template>> windAreas;
		public bool canInverse;
		public bool canStop;
		public bool enableAtStart;
		public Enum_flags flags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				windAreasOrigins = s.SerializeObject<CList<PhysForceModifier>>(windAreasOrigins, name: "windAreasOrigins");
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				windAreas = s.SerializeObject<CList<Generic<PhysForceModifier_Template>>>(windAreas, name: "windAreas");
			} else {
				windAreas = s.SerializeObject<CList<Generic<PhysForceModifier_Template>>>(windAreas, name: "windAreas");
				canInverse = s.Serialize<bool>(canInverse, name: "canInverse");
				canStop = s.Serialize<bool>(canStop, name: "canStop");
				enableAtStart = s.Serialize<bool>(enableAtStart, name: "enableAtStart");
				flags = s.Serialize<Enum_flags>(flags, name: "flags");
			}
		}
		public enum Enum_flags {
			[Serialize("OnlyApplyIfNotSticked")] OnlyApplyIfNotSticked = 1,
		}
		public override uint? ClassCRC => 0xCB67A691;
	}
}

