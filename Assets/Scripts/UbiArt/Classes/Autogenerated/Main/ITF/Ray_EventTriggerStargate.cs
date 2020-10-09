using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventTriggerStargate : Event {
		public Vec3d start;
		public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			start = s.SerializeObject<Vec3d>(start, name: "start");
			speed = s.Serialize<float>(speed, name: "speed");
		}
		public override uint? ClassCRC => 0xBA526589;
	}
}

