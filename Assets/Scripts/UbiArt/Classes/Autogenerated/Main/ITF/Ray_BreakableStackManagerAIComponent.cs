using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BreakableStackManagerAIComponent : Ray_AIComponent {
		public uint width;
		public uint height;
		public float gravityFall;
		public int iceMode;
		public int syncAnim;
		public float speedIceMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			width = s.Serialize<uint>(width, name: "width");
			height = s.Serialize<uint>(height, name: "height");
			gravityFall = s.Serialize<float>(gravityFall, name: "gravityFall");
			iceMode = s.Serialize<int>(iceMode, name: "iceMode");
			syncAnim = s.Serialize<int>(syncAnim, name: "syncAnim");
			speedIceMode = s.Serialize<float>(speedIceMode, name: "speedIceMode");
		}
		public override uint? ClassCRC => 0x75FDB171;
	}
}

