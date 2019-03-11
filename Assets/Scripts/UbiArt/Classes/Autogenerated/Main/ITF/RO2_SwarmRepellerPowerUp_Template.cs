using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SwarmRepellerPowerUp_Template : RO2_PowerUpDisplay_Template {
		[Serialize("repellerActor"     )] public Path repellerActor;
		[Serialize("playerFollowOffset")] public Vector2 playerFollowOffset;
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
		public override uint? ClassCRC => 0xDC99EBB2;
	}
}

