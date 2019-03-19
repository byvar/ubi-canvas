using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SwingRopeComponent_Template : SoftPlatformComponent_Template {
		[Serialize("maxSwingAngle"             )] public Angle maxSwingAngle;
		[Serialize("stiffGravityMultiplier"    )] public float stiffGravityMultiplier;
		[Serialize("stiffImpulseMultiplier"    )] public float stiffImpulseMultiplier;
		[Serialize("stiffSwingSpeedFriction"   )] public float stiffSwingSpeedFriction;
		[Serialize("nonStiffSwingSpeedFriction")] public float nonStiffSwingSpeedFriction;
		[Serialize("landDragMultiplier"        )] public float landDragMultiplier;
		[Serialize("landDragDuration"          )] public float landDragDuration;
		[Serialize("canUseSmall"               )] public bool canUseSmall;
		[Serialize("canUseNormal"              )] public bool canUseNormal;
		[Serialize("repositionWithBones"       )] public bool repositionWithBones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maxSwingAngle));
			SerializeField(s, nameof(stiffGravityMultiplier));
			SerializeField(s, nameof(stiffImpulseMultiplier));
			SerializeField(s, nameof(stiffSwingSpeedFriction));
			SerializeField(s, nameof(nonStiffSwingSpeedFriction));
			SerializeField(s, nameof(landDragMultiplier));
			SerializeField(s, nameof(landDragDuration));
			SerializeField(s, nameof(canUseSmall));
			SerializeField(s, nameof(canUseNormal));
			SerializeField(s, nameof(repositionWithBones));
		}
		public override uint? ClassCRC => 0x3751415B;
	}
}

