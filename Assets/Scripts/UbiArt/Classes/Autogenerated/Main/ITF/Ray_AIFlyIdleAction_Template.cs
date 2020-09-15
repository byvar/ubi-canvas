using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIFlyIdleAction_Template : AIAction_Template {
		public float stiff;
		public float damp;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stiff = s.Serialize<float>(stiff, name: "stiff");
			damp = s.Serialize<float>(damp, name: "damp");
		}
		public override uint? ClassCRC => 0xD78842C8;
	}
}

