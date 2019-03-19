using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_InflatedIslandComponent_Template : ActorComponent_Template {
		[Serialize("pos2Angle"          )] public float pos2Angle;
		[Serialize("pos2Pos"            )] public float pos2Pos;
		[Serialize("force2Pos"          )] public float force2Pos;
		[Serialize("force2Angle"        )] public float force2Angle;
		[Serialize("landForcePos"       )] public float landForcePos;
		[Serialize("hitForcePos"        )] public float hitForcePos;
		[Serialize("landForceAngle"     )] public float landForceAngle;
		[Serialize("hitForceAngle"      )] public float hitForceAngle;
		[Serialize("hitShake"           )] public float hitShake;
		[Serialize("landShake"          )] public float landShake;
		[Serialize("moveShake"          )] public float moveShake;
		[Serialize("kPos"               )] public float kPos;
		[Serialize("dPos"               )] public float dPos;
		[Serialize("kAngle"             )] public float kAngle;
		[Serialize("dAngle"             )] public float dAngle;
		[Serialize("kShake"             )] public float kShake;
		[Serialize("dShake"             )] public float dShake;
		[Serialize("forcePosReduction"  )] public float forcePosReduction;
		[Serialize("forceAngleReduction")] public float forceAngleReduction;
		[Serialize("shakeReduction"     )] public float shakeReduction;
		[Serialize("jumpFX"             )] public Path jumpFX;
		[Serialize("jumpFXOffset"       )] public Vector2 jumpFXOffset;
		[Serialize("jumpFXAngleLimit"   )] public Angle jumpFXAngleLimit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pos2Angle));
			SerializeField(s, nameof(pos2Pos));
			SerializeField(s, nameof(force2Pos));
			SerializeField(s, nameof(force2Angle));
			SerializeField(s, nameof(landForcePos));
			SerializeField(s, nameof(hitForcePos));
			SerializeField(s, nameof(landForceAngle));
			SerializeField(s, nameof(hitForceAngle));
			SerializeField(s, nameof(hitShake));
			SerializeField(s, nameof(landShake));
			SerializeField(s, nameof(moveShake));
			SerializeField(s, nameof(kPos));
			SerializeField(s, nameof(dPos));
			SerializeField(s, nameof(kAngle));
			SerializeField(s, nameof(dAngle));
			SerializeField(s, nameof(kShake));
			SerializeField(s, nameof(dShake));
			SerializeField(s, nameof(forcePosReduction));
			SerializeField(s, nameof(forceAngleReduction));
			SerializeField(s, nameof(shakeReduction));
			SerializeField(s, nameof(jumpFX));
			SerializeField(s, nameof(jumpFXOffset));
			SerializeField(s, nameof(jumpFXAngleLimit));
		}
		public override uint? ClassCRC => 0x96295076;
	}
}

