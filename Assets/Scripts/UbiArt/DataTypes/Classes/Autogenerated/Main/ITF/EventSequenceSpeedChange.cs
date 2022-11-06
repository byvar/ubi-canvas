using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventSequenceSpeedChange : Event {
		public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speed = s.Serialize<float>(speed, name: "speed");
		}
		public override uint? ClassCRC => 0xB50D406C;
	}
}

