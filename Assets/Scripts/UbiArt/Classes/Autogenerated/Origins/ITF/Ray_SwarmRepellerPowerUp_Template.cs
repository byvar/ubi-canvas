using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_SwarmRepellerPowerUp_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
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
		public override uint? ClassCRC => 0xB98D4052;
	}
}

