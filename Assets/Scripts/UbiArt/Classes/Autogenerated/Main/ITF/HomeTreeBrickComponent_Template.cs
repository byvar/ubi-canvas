using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class HomeTreeBrickComponent_Template : ActorComponent_Template {
		public uint editor_stepCount;
		public float editor_minGrowth;
		public Vec2d editor_brickSize;
		public float editor_trunkWidth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			editor_stepCount = s.Serialize<uint>(editor_stepCount, name: "editor_stepCount");
			editor_minGrowth = s.Serialize<float>(editor_minGrowth, name: "editor_minGrowth");
			editor_brickSize = s.SerializeObject<Vec2d>(editor_brickSize, name: "editor_brickSize");
			editor_trunkWidth = s.Serialize<float>(editor_trunkWidth, name: "editor_trunkWidth");
		}
		public override uint? ClassCRC => 0x86FD77D7;
	}
}

