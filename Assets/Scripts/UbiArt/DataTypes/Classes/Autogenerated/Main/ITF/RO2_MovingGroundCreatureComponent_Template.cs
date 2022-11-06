using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_MovingGroundCreatureComponent_Template : ActorComponent_Template {
		public float stepSize;
		public Path ringPath;
		public Path lianaPath;
		public StringID leftBoneName;
		public StringID rightBoneName;
		public StringID leftLianaBoneName;
		public StringID rightLianaBoneName;
		public Vec2d leftRingPosOffset;
		public Angle leftRingAngleOffset;
		public Vec2d rightRingPosOffset;
		public Angle rightRingAngleOffset;
		public Vec2d leftLianaPosOffset;
		public Angle leftLianaAngleOffset;
		public Vec2d rightLianaPosOffset;
		public Angle rightLianaAngleOffset;
		public StringID speedInput;
		public float ploufDuration;
		public float ploufAlteration;
		public Path pendouillePath;
		public StringID pendouilleBoneName;
		public Vec2d pendouillePosOffset;
		public Angle pendouilleAngleOffset;
		public CListO<StringID> pendouilleAnims;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stepSize = s.Serialize<float>(stepSize, name: "stepSize");
			ringPath = s.SerializeObject<Path>(ringPath, name: "ringPath");
			lianaPath = s.SerializeObject<Path>(lianaPath, name: "lianaPath");
			leftBoneName = s.SerializeObject<StringID>(leftBoneName, name: "leftBoneName");
			rightBoneName = s.SerializeObject<StringID>(rightBoneName, name: "rightBoneName");
			leftLianaBoneName = s.SerializeObject<StringID>(leftLianaBoneName, name: "leftLianaBoneName");
			rightLianaBoneName = s.SerializeObject<StringID>(rightLianaBoneName, name: "rightLianaBoneName");
			leftRingPosOffset = s.SerializeObject<Vec2d>(leftRingPosOffset, name: "leftRingPosOffset");
			leftRingAngleOffset = s.SerializeObject<Angle>(leftRingAngleOffset, name: "leftRingAngleOffset");
			rightRingPosOffset = s.SerializeObject<Vec2d>(rightRingPosOffset, name: "rightRingPosOffset");
			rightRingAngleOffset = s.SerializeObject<Angle>(rightRingAngleOffset, name: "rightRingAngleOffset");
			leftLianaPosOffset = s.SerializeObject<Vec2d>(leftLianaPosOffset, name: "leftLianaPosOffset");
			leftLianaAngleOffset = s.SerializeObject<Angle>(leftLianaAngleOffset, name: "leftLianaAngleOffset");
			rightLianaPosOffset = s.SerializeObject<Vec2d>(rightLianaPosOffset, name: "rightLianaPosOffset");
			rightLianaAngleOffset = s.SerializeObject<Angle>(rightLianaAngleOffset, name: "rightLianaAngleOffset");
			speedInput = s.SerializeObject<StringID>(speedInput, name: "speedInput");
			ploufDuration = s.Serialize<float>(ploufDuration, name: "ploufDuration");
			ploufAlteration = s.Serialize<float>(ploufAlteration, name: "ploufAlteration");
			pendouillePath = s.SerializeObject<Path>(pendouillePath, name: "pendouillePath");
			pendouilleBoneName = s.SerializeObject<StringID>(pendouilleBoneName, name: "pendouilleBoneName");
			pendouillePosOffset = s.SerializeObject<Vec2d>(pendouillePosOffset, name: "pendouillePosOffset");
			pendouilleAngleOffset = s.SerializeObject<Angle>(pendouilleAngleOffset, name: "pendouilleAngleOffset");
			pendouilleAnims = s.SerializeObject<CListO<StringID>>(pendouilleAnims, name: "pendouilleAnims");
		}
		public override uint? ClassCRC => 0x518C14A2;
	}
}

