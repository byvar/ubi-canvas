using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventForceConstantSpeed : Event {
		public bool enter;
		public float speed;
		public float blendInDuration;
		public float blendOutDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enter = s.Serialize<bool>(enter, name: "enter");
			speed = s.Serialize<float>(speed, name: "speed");
			blendInDuration = s.Serialize<float>(blendInDuration, name: "blendInDuration");
			blendOutDuration = s.Serialize<float>(blendOutDuration, name: "blendOutDuration");
		}
		public override uint? ClassCRC => 0x0491AD14;
	}
}

