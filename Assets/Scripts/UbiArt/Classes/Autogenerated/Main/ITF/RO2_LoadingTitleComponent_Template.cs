using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_LoadingTitleComponent_Template : ActorComponent_Template {
		public Path textPath;
		public Vec2d screenPos;
		public SmartLocId locId;
		public SmartLocId homeLocId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			textPath = s.SerializeObject<Path>(textPath, name: "textPath");
			screenPos = s.SerializeObject<Vec2d>(screenPos, name: "screenPos");
			locId = s.SerializeObject<SmartLocId>(locId, name: "locId");
			homeLocId = s.SerializeObject<SmartLocId>(homeLocId, name: "homeLocId");
		}
		public override uint? ClassCRC => 0xB755C5E7;
	}
}

