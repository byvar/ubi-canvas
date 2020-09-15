using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_RFR_TeensyUnlockManagerComponent_Template : Ray_AIComponent_Template {
		public Path Path__0;
		public uint uint__1;
		public float float__2;
		public float float__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
			uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
		}
		public override uint? ClassCRC => 0x1776BC3E;
	}
}

