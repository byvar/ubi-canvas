using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_HeartShield_Template : RO2_PowerUpDisplay_Template {
		[Serialize("heartActor"           )] public Path heartActor;
		[Serialize("heartDeathBhvName"    )] public StringID heartDeathBhvName;
		[Serialize("heartAppearBhvName"   )] public StringID heartAppearBhvName;
		[Serialize("playerFollowOffset"   )] public Vector2 playerFollowOffset;
		[Serialize("speedBlend"           )] public float speedBlend;
		[Serialize("speedMin"             )] public float speedMin;
		[Serialize("speedMax"             )] public float speedMax;
		[Serialize("blendAtSpeedMin"      )] public float blendAtSpeedMin;
		[Serialize("blendAtSpeedMax"      )] public float blendAtSpeedMax;
		[Serialize("depthOffset"          )] public float depthOffset;
		[Serialize("approachDistance"     )] public float approachDistance;
		[Serialize("approachStartBlend"   )] public float approachStartBlend;
		[Serialize("approachEndBlend"     )] public float approachEndBlend;
		[Serialize("approachBlendTime"    )] public float approachBlendTime;
		[Serialize("m_approachEndDistance")] public float m_approachEndDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(heartActor));
			SerializeField(s, nameof(heartDeathBhvName));
			SerializeField(s, nameof(heartAppearBhvName));
			SerializeField(s, nameof(playerFollowOffset));
			SerializeField(s, nameof(speedBlend));
			SerializeField(s, nameof(speedMin));
			SerializeField(s, nameof(speedMax));
			SerializeField(s, nameof(blendAtSpeedMin));
			SerializeField(s, nameof(blendAtSpeedMax));
			SerializeField(s, nameof(depthOffset));
			SerializeField(s, nameof(approachDistance));
			SerializeField(s, nameof(approachStartBlend));
			SerializeField(s, nameof(approachEndBlend));
			SerializeField(s, nameof(approachBlendTime));
			SerializeField(s, nameof(m_approachEndDistance));
		}
		public override uint? ClassCRC => 0x38602DC1;
	}
}

