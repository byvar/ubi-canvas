using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_462_sub_B90640 : CSerializable {
		[Serialize("idle"                  )] public Placeholder idle;
		[Serialize("hit"                   )] public Placeholder hit;
		[Serialize("giveup"                )] public Placeholder giveup;
		[Serialize("attackDistance"        )] public float attackDistance;
		[Serialize("gunPivotBone"          )] public StringID gunPivotBone;
		[Serialize("rotateUsingAnimation"  )] public int rotateUsingAnimation;
		[Serialize("minAngle"              )] public Angle minAngle;
		[Serialize("maxAngle"              )] public Angle maxAngle;
		[Serialize("minMaxAngleFlip"       )] public int minMaxAngleFlip;
		[Serialize("lookRight"             )] public int lookRight;
		[Serialize("giveUpRange"           )] public float giveUpRange;
		[Serialize("aimCursorRestingPos"   )] public float aimCursorRestingPos;
		[Serialize("aimTimeToFade"         )] public float aimTimeToFade;
		[Serialize("aimOffset"             )] public float aimOffset;
		[Serialize("forceAngle"            )] public int forceAngle;
		[Serialize("forcedAngle"           )] public Angle forcedAngle;
		[Serialize("keepDirForBurst"       )] public int keepDirForBurst;
		[Serialize("autoForceDir"          )] public int autoForceDir;
		[Serialize("DEBUG_disableAttack"   )] public int DEBUG_disableAttack;
		[Serialize("canonPivotBoneName"    )] public StringID canonPivotBoneName;
		[Serialize("canonExtremityBoneName")] public StringID canonExtremityBoneName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(hit));
			SerializeField(s, nameof(giveup));
			SerializeField(s, nameof(attackDistance));
			SerializeField(s, nameof(gunPivotBone));
			SerializeField(s, nameof(rotateUsingAnimation));
			SerializeField(s, nameof(minAngle));
			SerializeField(s, nameof(maxAngle));
			SerializeField(s, nameof(minMaxAngleFlip));
			SerializeField(s, nameof(lookRight));
			SerializeField(s, nameof(giveUpRange));
			SerializeField(s, nameof(aimCursorRestingPos));
			SerializeField(s, nameof(aimTimeToFade));
			SerializeField(s, nameof(aimOffset));
			SerializeField(s, nameof(forceAngle));
			SerializeField(s, nameof(forcedAngle));
			SerializeField(s, nameof(keepDirForBurst));
			SerializeField(s, nameof(autoForceDir));
			SerializeField(s, nameof(DEBUG_disableAttack));
			SerializeField(s, nameof(canonPivotBoneName));
			SerializeField(s, nameof(canonExtremityBoneName));
		}
		public override uint? ClassCRC => 0xF17950F3;
	}
}

