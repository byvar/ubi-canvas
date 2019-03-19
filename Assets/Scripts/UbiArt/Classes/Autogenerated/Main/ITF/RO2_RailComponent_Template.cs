using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RailComponent_Template : ActorComponent_Template {
		[Serialize("speedMax"       )] public float speedMax;
		[Serialize("reboundFriction")] public float reboundFriction;
		[Serialize("circleMode"     )] public bool circleMode;
		[Serialize("radius"         )] public float radius;
		[Serialize("initAngle"      )] public Angle initAngle;
		[Serialize("useSnap"        )] public bool useSnap;
		[Serialize("snapTolerance"  )] public float snapTolerance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speedMax));
			SerializeField(s, nameof(reboundFriction));
			SerializeField(s, nameof(circleMode));
			SerializeField(s, nameof(radius));
			SerializeField(s, nameof(initAngle));
			SerializeField(s, nameof(useSnap));
			SerializeField(s, nameof(snapTolerance));
		}
		public override uint? ClassCRC => 0x4C430640;
	}
}

