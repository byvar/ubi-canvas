using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_VehicleSettings_Evt : Event {
		public bool bool__0;
		public bool bool__1;
		public bool bool__2;
		public bool bool__3;
		public float float__4;
		public float float__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
			bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
			float__4 = s.Serialize<float>(float__4, name: "float__4");
			float__5 = s.Serialize<float>(float__5, name: "float__5");
		}
		public override uint? ClassCRC => 0xBB8AE2FB;
	}
}

