using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MovingGroundCreatureComponent_Template : ActorComponent_Template {
		[Serialize("stepSize"             )] public float stepSize;
		[Serialize("ringPath"             )] public Path ringPath;
		[Serialize("lianaPath"            )] public Path lianaPath;
		[Serialize("leftBoneName"         )] public StringID leftBoneName;
		[Serialize("rightBoneName"        )] public StringID rightBoneName;
		[Serialize("leftLianaBoneName"    )] public StringID leftLianaBoneName;
		[Serialize("rightLianaBoneName"   )] public StringID rightLianaBoneName;
		[Serialize("leftRingPosOffset"    )] public Vec2d leftRingPosOffset;
		[Serialize("leftRingAngleOffset"  )] public Angle leftRingAngleOffset;
		[Serialize("rightRingPosOffset"   )] public Vec2d rightRingPosOffset;
		[Serialize("rightRingAngleOffset" )] public Angle rightRingAngleOffset;
		[Serialize("leftLianaPosOffset"   )] public Vec2d leftLianaPosOffset;
		[Serialize("leftLianaAngleOffset" )] public Angle leftLianaAngleOffset;
		[Serialize("rightLianaPosOffset"  )] public Vec2d rightLianaPosOffset;
		[Serialize("rightLianaAngleOffset")] public Angle rightLianaAngleOffset;
		[Serialize("speedInput"           )] public StringID speedInput;
		[Serialize("ploufDuration"        )] public float ploufDuration;
		[Serialize("ploufAlteration"      )] public float ploufAlteration;
		[Serialize("pendouillePath"       )] public Path pendouillePath;
		[Serialize("pendouilleBoneName"   )] public StringID pendouilleBoneName;
		[Serialize("pendouillePosOffset"  )] public Vec2d pendouillePosOffset;
		[Serialize("pendouilleAngleOffset")] public Angle pendouilleAngleOffset;
		[Serialize("pendouilleAnims"      )] public CList<StringID> pendouilleAnims;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stepSize));
			SerializeField(s, nameof(ringPath));
			SerializeField(s, nameof(lianaPath));
			SerializeField(s, nameof(leftBoneName));
			SerializeField(s, nameof(rightBoneName));
			SerializeField(s, nameof(leftLianaBoneName));
			SerializeField(s, nameof(rightLianaBoneName));
			SerializeField(s, nameof(leftRingPosOffset));
			SerializeField(s, nameof(leftRingAngleOffset));
			SerializeField(s, nameof(rightRingPosOffset));
			SerializeField(s, nameof(rightRingAngleOffset));
			SerializeField(s, nameof(leftLianaPosOffset));
			SerializeField(s, nameof(leftLianaAngleOffset));
			SerializeField(s, nameof(rightLianaPosOffset));
			SerializeField(s, nameof(rightLianaAngleOffset));
			SerializeField(s, nameof(speedInput));
			SerializeField(s, nameof(ploufDuration));
			SerializeField(s, nameof(ploufAlteration));
			SerializeField(s, nameof(pendouillePath));
			SerializeField(s, nameof(pendouilleBoneName));
			SerializeField(s, nameof(pendouillePosOffset));
			SerializeField(s, nameof(pendouilleAngleOffset));
			SerializeField(s, nameof(pendouilleAnims));
		}
		public override uint? ClassCRC => 0x518C14A2;
	}
}

