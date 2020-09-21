using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LevelIndicatorComponent_Template : ActorComponent_Template {
		public CListO<SmartLocId> levels;
		public float displayDuration;
		public float transitionDuration;
		public uint nbRebound;
		public Vec2d startOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			levels = s.SerializeObject<CListO<SmartLocId>>(levels, name: "levels");
			displayDuration = s.Serialize<float>(displayDuration, name: "displayDuration");
			transitionDuration = s.Serialize<float>(transitionDuration, name: "transitionDuration");
			nbRebound = s.Serialize<uint>(nbRebound, name: "nbRebound");
			startOffset = s.SerializeObject<Vec2d>(startOffset, name: "startOffset");
		}
		public override uint? ClassCRC => 0xAC2A915C;
	}
}

