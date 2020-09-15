using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_HeartShield_Template : Ray_PowerUpDisplay_Template {
		[Serialize("heartActor"        )] public Path heartActor;
		[Serialize("heartDeathBhvName" )] public StringID heartDeathBhvName;
		[Serialize("playerFollowOffset")] public Vec2d playerFollowOffset;
		[Serialize("speedBlend"        )] public float speedBlend;
		[Serialize("speedMin"          )] public float speedMin;
		[Serialize("speedMax"          )] public float speedMax;
		[Serialize("blendAtSpeedMin"   )] public float blendAtSpeedMin;
		[Serialize("blendAtSpeedMax"   )] public float blendAtSpeedMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(heartActor));
			SerializeField(s, nameof(heartDeathBhvName));
			SerializeField(s, nameof(playerFollowOffset));
			SerializeField(s, nameof(speedBlend));
			SerializeField(s, nameof(speedMin));
			SerializeField(s, nameof(speedMax));
			SerializeField(s, nameof(blendAtSpeedMin));
			SerializeField(s, nameof(blendAtSpeedMax));
		}
		public override uint? ClassCRC => 0xF663C88B;
	}
}

