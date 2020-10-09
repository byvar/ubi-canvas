using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PlugState_Jump_Template : ActorPlugStateImplement_Template {
		public float wallImpulseForce;
		public Vec2d wallBounceMinSpeed;
		public float airBrakeAnimBlendSpeed;
		public float bounceRepositionDuration;
		public float bouncePlatformLevel1Height;
		public float bouncePlatformLevel1NoControlDelay;
		public float bouncePlatformLevel1AirControlBlendFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			wallImpulseForce = s.Serialize<float>(wallImpulseForce, name: "wallImpulseForce");
			wallBounceMinSpeed = s.SerializeObject<Vec2d>(wallBounceMinSpeed, name: "wallBounceMinSpeed");
			airBrakeAnimBlendSpeed = s.Serialize<float>(airBrakeAnimBlendSpeed, name: "airBrakeAnimBlendSpeed");
			bounceRepositionDuration = s.Serialize<float>(bounceRepositionDuration, name: "bounceRepositionDuration");
			bouncePlatformLevel1Height = s.Serialize<float>(bouncePlatformLevel1Height, name: "bouncePlatformLevel1Height");
			bouncePlatformLevel1NoControlDelay = s.Serialize<float>(bouncePlatformLevel1NoControlDelay, name: "bouncePlatformLevel1NoControlDelay");
			bouncePlatformLevel1AirControlBlendFactor = s.Serialize<float>(bouncePlatformLevel1AirControlBlendFactor, name: "bouncePlatformLevel1AirControlBlendFactor");
		}
		public override uint? ClassCRC => 0xAE791349;
	}
}

