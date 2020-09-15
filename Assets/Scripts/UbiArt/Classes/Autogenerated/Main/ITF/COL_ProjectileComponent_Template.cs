using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_ProjectileComponent_Template : CSerializable {
		public float speed;
		public float delay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speed = s.Serialize<float>(speed, name: "speed");
			delay = s.Serialize<float>(delay, name: "delay");
		}
		public override uint? ClassCRC => 0x2E8A2705;
	}
}

