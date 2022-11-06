using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_CreditsComponent : CreditsComponent {
		public float float__0;
		public float float__1;
		public float float__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
		}
		public override uint? ClassCRC => 0xE8B8591B;
	}
}

