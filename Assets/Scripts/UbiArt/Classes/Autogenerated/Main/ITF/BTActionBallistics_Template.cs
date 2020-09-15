using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BTActionBallistics_Template : BTAction_Template {
		public StringID factTargetPos;
		public StringID anim;
		public float duration;
		public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			factTargetPos = s.SerializeObject<StringID>(factTargetPos, name: "factTargetPos");
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			duration = s.Serialize<float>(duration, name: "duration");
			speed = s.Serialize<float>(speed, name: "speed");
		}
		public override uint? ClassCRC => 0x7BB9644A;
	}
}

