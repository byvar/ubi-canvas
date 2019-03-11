using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PlugState_Jump_Template : ActorPlugStateImplement_Template {
		[Serialize("wallImpulseForce"                         )] public float wallImpulseForce;
		[Serialize("wallBounceMinSpeed"                       )] public Vector2 wallBounceMinSpeed;
		[Serialize("airBrakeAnimBlendSpeed"                   )] public float airBrakeAnimBlendSpeed;
		[Serialize("bounceRepositionDuration"                 )] public float bounceRepositionDuration;
		[Serialize("bouncePlatformLevel1Height"               )] public float bouncePlatformLevel1Height;
		[Serialize("bouncePlatformLevel1NoControlDelay"       )] public float bouncePlatformLevel1NoControlDelay;
		[Serialize("bouncePlatformLevel1AirControlBlendFactor")] public float bouncePlatformLevel1AirControlBlendFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(wallImpulseForce));
			SerializeField(s, nameof(wallBounceMinSpeed));
			SerializeField(s, nameof(airBrakeAnimBlendSpeed));
			SerializeField(s, nameof(bounceRepositionDuration));
			SerializeField(s, nameof(bouncePlatformLevel1Height));
			SerializeField(s, nameof(bouncePlatformLevel1NoControlDelay));
			SerializeField(s, nameof(bouncePlatformLevel1AirControlBlendFactor));
		}
		public override uint? ClassCRC => 0xAE791349;
	}
}

