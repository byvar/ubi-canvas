using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RopeHookComponent : ActorComponent {
		[Serialize("touchHandler"             )] public RO2_TouchHandler touchHandler;
		[Serialize("torqueFriction"           )] public float torqueFriction;
		[Serialize("attachmentDetectionRadius")] public float attachmentDetectionRadius;
		[Serialize("hookingSmoothFactor"      )] public float hookingSmoothFactor;
		[Serialize("hookOffset"               )] public Vec2d hookOffset;
		[Serialize("angleOffset"              )] public Angle angleOffset;
		[Serialize("angleSmoothingFactor"     )] public float angleSmoothingFactor;
		[Serialize("snapDist"                 )] public float snapDist;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(touchHandler));
			SerializeField(s, nameof(torqueFriction));
			SerializeField(s, nameof(attachmentDetectionRadius));
			SerializeField(s, nameof(hookingSmoothFactor));
			SerializeField(s, nameof(hookOffset));
			SerializeField(s, nameof(angleOffset));
			SerializeField(s, nameof(angleSmoothingFactor));
			SerializeField(s, nameof(snapDist));
		}
		public override uint? ClassCRC => 0x3DCA3879;
	}
}

