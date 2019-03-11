using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_RetractOnTapEyeBranchComponent_Template : RO2_BezierBranchComponent_Template {
		[Serialize("tapRetractDistance"    )] public float tapRetractDistance;
		[Serialize("tapRetractSpeedSmoothA")] public float tapRetractSpeedSmoothA;
		[Serialize("tapRetractSpeedSmoothB")] public float tapRetractSpeedSmoothB;
		[Serialize("growBackCooldown"      )] public float growBackCooldown;
		[Serialize("growBackSpeedSmoothA"  )] public float growBackSpeedSmoothA;
		[Serialize("growBackSpeedSmoothB"  )] public float growBackSpeedSmoothB;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tapRetractDistance));
			SerializeField(s, nameof(tapRetractSpeedSmoothA));
			SerializeField(s, nameof(tapRetractSpeedSmoothB));
			SerializeField(s, nameof(growBackCooldown));
			SerializeField(s, nameof(growBackSpeedSmoothA));
			SerializeField(s, nameof(growBackSpeedSmoothB));
		}
		public override uint? ClassCRC => 0x32976BAD;
	}
}

