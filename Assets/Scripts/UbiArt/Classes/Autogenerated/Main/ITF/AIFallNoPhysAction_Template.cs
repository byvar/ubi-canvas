using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AIFallNoPhysAction_Template : AIAction_Template {
		public float duration;
		public float fakeGravity;
		public float maxSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			duration = s.Serialize<float>(duration, name: "duration");
			fakeGravity = s.Serialize<float>(fakeGravity, name: "fakeGravity");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
		}
		public override uint? ClassCRC => 0xC0F9AD01;
	}
}

