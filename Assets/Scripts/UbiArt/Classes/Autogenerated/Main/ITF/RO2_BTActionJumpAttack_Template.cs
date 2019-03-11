using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionJumpAttack_Template : BTAction_Template {
		[Serialize("animAnticip"      )] public StringID animAnticip;
		[Serialize("animJump"         )] public StringID animJump;
		[Serialize("animWallStand"    )] public StringID animWallStand;
		[Serialize("animWallJump"     )] public StringID animWallJump;
		[Serialize("animReception"    )] public StringID animReception;
		[Serialize("jumpImpulse"      )] public float jumpImpulse;
		[Serialize("jumpDir"          )] public Vector2 jumpDir;
		[Serialize("wallJumpImpulse"  )] public float wallJumpImpulse;
		[Serialize("wallJumpDir"      )] public Vector2 wallJumpDir;
		[Serialize("jumpGravityMult"  )] public float jumpGravityMult;
		[Serialize("holeDetectionDist")] public float holeDetectionDist;
		[Serialize("wallDetectionDist")] public float wallDetectionDist;
		[Serialize("timeAnticip"      )] public float timeAnticip;
		[Serialize("timeWallAnticip"  )] public float timeWallAnticip;
		[Serialize("avoidHoles"       )] public bool avoidHoles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animAnticip));
			SerializeField(s, nameof(animJump));
			SerializeField(s, nameof(animWallStand));
			SerializeField(s, nameof(animWallJump));
			SerializeField(s, nameof(animReception));
			SerializeField(s, nameof(jumpImpulse));
			SerializeField(s, nameof(jumpDir));
			SerializeField(s, nameof(wallJumpImpulse));
			SerializeField(s, nameof(wallJumpDir));
			SerializeField(s, nameof(jumpGravityMult));
			SerializeField(s, nameof(holeDetectionDist));
			SerializeField(s, nameof(wallDetectionDist));
			SerializeField(s, nameof(timeAnticip));
			SerializeField(s, nameof(timeWallAnticip));
			SerializeField(s, nameof(avoidHoles));
		}
		public override uint? ClassCRC => 0x05360873;
	}
}

