using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_RFR_ItemComponent : ActorComponent {
		public int int__0;
		public int int__1;
		public bool bool__2;
		public int int__3;
		public uint uint__4;
		public int int__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			int__0 = s.Serialize<int>(int__0, name: "int__0");
			int__1 = s.Serialize<int>(int__1, name: "int__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
			int__3 = s.Serialize<int>(int__3, name: "int__3");
			uint__4 = s.Serialize<uint>(uint__4, name: "uint__4");
			int__5 = s.Serialize<int>(int__5, name: "int__5");
		}
		public override uint? ClassCRC => 0x420B2AEB;
	}
}

