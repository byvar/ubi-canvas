using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionHitTarget_Template : BTAction_Template {
		[Serialize("attacks"                   )] public CList<RO2_BTActionHitTarget_Template.AttackData> attacks;
		[Serialize("fxBoneName"                )] public StringID fxBoneName;
		[Serialize("forceJumpAttack"           )] public float forceJumpAttack;
		[Serialize("angleJumpAttack"           )] public Angle angleJumpAttack;
		[Serialize("fxNames"                   )] public CList<StringID> fxNames;
		[Serialize("fxMarkerStart"             )] public CList<StringID> fxMarkerStart;
		[Serialize("fxMarkerStop"              )] public CList<StringID> fxMarkerStop;
		[Serialize("lightningStart"            )] public StringID lightningStart;
		[Serialize("lightningStop"             )] public StringID lightningStop;
		[Serialize("lightningCharge"           )] public StringID lightningCharge;
		[Serialize("useShakeCamera"            )] public bool useShakeCamera;
		[Serialize("canMemorizeHitWithDuration")] public bool canMemorizeHitWithDuration;
		[Serialize("memorizeHitDuration"       )] public float memorizeHitDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(attacks));
			SerializeField(s, nameof(fxBoneName));
			SerializeField(s, nameof(forceJumpAttack));
			SerializeField(s, nameof(angleJumpAttack));
			SerializeField(s, nameof(fxNames));
			SerializeField(s, nameof(fxMarkerStart));
			SerializeField(s, nameof(fxMarkerStop));
			SerializeField(s, nameof(lightningStart));
			SerializeField(s, nameof(lightningStop));
			SerializeField(s, nameof(lightningCharge));
			SerializeField(s, nameof(useShakeCamera));
			SerializeField(s, nameof(canMemorizeHitWithDuration));
			SerializeField(s, nameof(memorizeHitDuration));
		}
		[Games(GameFlags.RA)]
		public partial class AttackData : CSerializable {
			[Serialize("punchType"               )] public PUNCHTYPE punchType;
			[Serialize("level"                   )] public uint level;
			[Serialize("pushBackRadius"          )] public float pushBackRadius;
			[Serialize("duration"                )] public float duration;
			[Serialize("anim"                    )] public StringID anim;
			[Serialize("updateHitShape"          )] public bool updateHitShape;
			[Serialize("canUseAnimationRootDelta")] public bool canUseAnimationRootDelta;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(punchType));
				SerializeField(s, nameof(level));
				SerializeField(s, nameof(pushBackRadius));
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(updateHitShape));
				SerializeField(s, nameof(canUseAnimationRootDelta));
			}
			public enum PUNCHTYPE {
				[Serialize("PUNCHTYPE_CHARGE"    )] CHARGE = 0,
				[Serialize("PUNCHTYPE_CRUSH"     )] CRUSH = 1,
				[Serialize("PUNCHTYPE_CROUCHKICK")] CROUCHKICK = 2,
				[Serialize("PUNCHTYPE_TORNADO"   )] TORNADO = 3,
				[Serialize("PUNCHTYPE_REPEATING" )] REPEATING = 4,
				[Serialize("PUNCHTYPE_SPIN"      )] SPIN = 5,
				[Serialize("PUNCHTYPE_TORNADOZIP")] TORNADOZIP = 6,
				[Serialize("PUNCHTYPE_UTURNKICK" )] UTURNKICK = 7,
				[Serialize("PUNCHTYPE_UPPERKICK" )] UPPERKICK = 9,
			}
		}
		public override uint? ClassCRC => 0xE1DF994C;
	}
}

