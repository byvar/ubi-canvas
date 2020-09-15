using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_RFR_LevelComponent : ActorComponent {
		public uint uint__0;
		public uint uint__1;
		public uint uint__2;
		public int int__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
			uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
			uint__2 = s.Serialize<uint>(uint__2, name: "uint__2");
			int__3 = s.Serialize<int>(int__3, name: "int__3");
		}
		public override uint? ClassCRC => 0x995963EC;
	}
}

