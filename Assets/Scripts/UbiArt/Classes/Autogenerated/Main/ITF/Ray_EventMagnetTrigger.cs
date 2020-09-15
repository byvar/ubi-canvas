using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventMagnetTrigger : EventTrigger {
		public float magnetForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			magnetForce = s.Serialize<float>(magnetForce, name: "magnetForce");
		}
		public override uint? ClassCRC => 0x0660A7C6;
	}
}

