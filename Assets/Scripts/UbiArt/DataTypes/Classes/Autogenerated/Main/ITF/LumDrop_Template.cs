using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class LumDrop_Template : CSerializable {
		public float float__0;
		public Angle Angle__1;
		public float float__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			Angle__1 = s.SerializeObject<Angle>(Angle__1, name: "Angle__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
		}
	}
}

