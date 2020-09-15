using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_InflatedIslandComponent_Template : ActorComponent_Template {
		public float pos2Angle;
		public float pos2Pos;
		public float force2Pos;
		public float force2Angle;
		public float landForcePos;
		public float hitForcePos;
		public float landForceAngle;
		public float hitForceAngle;
		public float hitShake;
		public float landShake;
		public float moveShake;
		public float kPos;
		public float dPos;
		public float kAngle;
		public float dAngle;
		public float kShake;
		public float dShake;
		public float forcePosReduction;
		public float forceAngleReduction;
		public float shakeReduction;
		public Path jumpFX;
		public Vec2d jumpFXOffset;
		public Angle jumpFXAngleLimit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pos2Angle = s.Serialize<float>(pos2Angle, name: "pos2Angle");
			pos2Pos = s.Serialize<float>(pos2Pos, name: "pos2Pos");
			force2Pos = s.Serialize<float>(force2Pos, name: "force2Pos");
			force2Angle = s.Serialize<float>(force2Angle, name: "force2Angle");
			landForcePos = s.Serialize<float>(landForcePos, name: "landForcePos");
			hitForcePos = s.Serialize<float>(hitForcePos, name: "hitForcePos");
			landForceAngle = s.Serialize<float>(landForceAngle, name: "landForceAngle");
			hitForceAngle = s.Serialize<float>(hitForceAngle, name: "hitForceAngle");
			hitShake = s.Serialize<float>(hitShake, name: "hitShake");
			landShake = s.Serialize<float>(landShake, name: "landShake");
			moveShake = s.Serialize<float>(moveShake, name: "moveShake");
			kPos = s.Serialize<float>(kPos, name: "kPos");
			dPos = s.Serialize<float>(dPos, name: "dPos");
			kAngle = s.Serialize<float>(kAngle, name: "kAngle");
			dAngle = s.Serialize<float>(dAngle, name: "dAngle");
			kShake = s.Serialize<float>(kShake, name: "kShake");
			dShake = s.Serialize<float>(dShake, name: "dShake");
			forcePosReduction = s.Serialize<float>(forcePosReduction, name: "forcePosReduction");
			forceAngleReduction = s.Serialize<float>(forceAngleReduction, name: "forceAngleReduction");
			shakeReduction = s.Serialize<float>(shakeReduction, name: "shakeReduction");
			jumpFX = s.SerializeObject<Path>(jumpFX, name: "jumpFX");
			jumpFXOffset = s.SerializeObject<Vec2d>(jumpFXOffset, name: "jumpFXOffset");
			jumpFXAngleLimit = s.SerializeObject<Angle>(jumpFXAngleLimit, name: "jumpFXAngleLimit");
		}
		public override uint? ClassCRC => 0x96295076;
	}
}

