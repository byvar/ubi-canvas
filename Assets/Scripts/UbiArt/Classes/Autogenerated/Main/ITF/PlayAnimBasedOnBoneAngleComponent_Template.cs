using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayAnimBasedOnBoneAngleComponent_Template : ActorComponent_Template {
		[Serialize("bone"    )] public StringID bone;
		[Serialize("minAngle")] public Angle minAngle;
		[Serialize("maxAngle")] public Angle maxAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bone));
			SerializeField(s, nameof(minAngle));
			SerializeField(s, nameof(maxAngle));
		}
		public override uint? ClassCRC => 0xFE30FA88;
	}
}

