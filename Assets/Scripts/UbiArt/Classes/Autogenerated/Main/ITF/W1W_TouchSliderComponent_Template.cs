using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_TouchSliderComponent_Template : ActorComponent_Template {
		public float float__0;
		public bool bool__1;
		public bool bool__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
		}
		public override uint? ClassCRC => 0x72D0BC93;
	}
}

