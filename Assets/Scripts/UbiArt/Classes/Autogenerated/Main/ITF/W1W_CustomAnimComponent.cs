using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_CustomAnimComponent : ActorComponent {
		public bool bool__0;
		public float float__1;
		public bool bool__2;
		public float float__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
		}
		public override uint? ClassCRC => 0x09FC5C0A;
	}
}

