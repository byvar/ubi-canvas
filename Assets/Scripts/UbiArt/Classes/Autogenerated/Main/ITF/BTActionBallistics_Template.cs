using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BTActionBallistics_Template : BTAction_Template {
		[Serialize("factTargetPos")] public StringID factTargetPos;
		[Serialize("anim"         )] public StringID anim;
		[Serialize("duration"     )] public float duration;
		[Serialize("speed"        )] public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(factTargetPos));
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(duration));
			SerializeField(s, nameof(speed));
		}
		public override uint? ClassCRC => 0x7BB9644A;
	}
}

