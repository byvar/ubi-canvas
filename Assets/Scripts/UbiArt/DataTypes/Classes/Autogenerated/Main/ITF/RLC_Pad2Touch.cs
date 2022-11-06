using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Pad2Touch : ActorComponent {
		public Vec2d OffSet;
		public string viewportName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			OffSet = s.SerializeObject<Vec2d>(OffSet, name: "OffSet");
			viewportName = s.Serialize<string>(viewportName, name: "viewportName");
		}
		public override uint? ClassCRC => 0x2117995D;
	}
}

