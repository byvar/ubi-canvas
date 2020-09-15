using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_SwarmRepellerPowerUp_Template : Ray_PowerUpDisplay_Template {
		[Serialize("repellerActor"     )] public Path repellerActor;
		[Serialize("playerFollowOffset")] public Vec2d playerFollowOffset;
		[Serialize("speedBlend"        )] public float speedBlend;
		[Serialize("speedMin"          )] public float speedMin;
		[Serialize("speedMax"          )] public float speedMax;
		[Serialize("blendAtSpeedMin"   )] public float blendAtSpeedMin;
		[Serialize("blendAtSpeedMax"   )] public float blendAtSpeedMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(repellerActor));
			SerializeField(s, nameof(playerFollowOffset));
			SerializeField(s, nameof(speedBlend));
			SerializeField(s, nameof(speedMin));
			SerializeField(s, nameof(speedMax));
			SerializeField(s, nameof(blendAtSpeedMin));
			SerializeField(s, nameof(blendAtSpeedMax));
		}
		public override uint? ClassCRC => 0xB98D4052;
	}
}

