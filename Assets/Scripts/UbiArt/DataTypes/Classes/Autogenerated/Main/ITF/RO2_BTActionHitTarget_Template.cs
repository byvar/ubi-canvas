namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionHitTarget_Template : BTAction_Template {
		public CListO<RO2_BTActionHitTarget_Template.AttackData> attacks;
		public StringID fxBoneName;
		public float forceJumpAttack;
		public Angle angleJumpAttack;
		public CListO<StringID> fxNames;
		public CListO<StringID> fxMarkerStart;
		public CListO<StringID> fxMarkerStop;
		public StringID lightningStart;
		public StringID lightningStop;
		public StringID lightningCharge;
		public bool useShakeCamera;
		public bool canMemorizeHitWithDuration;
		public float memorizeHitDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			attacks = s.SerializeObject<CListO<RO2_BTActionHitTarget_Template.AttackData>>(attacks, name: "attacks");
			fxBoneName = s.SerializeObject<StringID>(fxBoneName, name: "fxBoneName");
			forceJumpAttack = s.Serialize<float>(forceJumpAttack, name: "forceJumpAttack");
			angleJumpAttack = s.SerializeObject<Angle>(angleJumpAttack, name: "angleJumpAttack");
			fxNames = s.SerializeObject<CListO<StringID>>(fxNames, name: "fxNames");
			fxMarkerStart = s.SerializeObject<CListO<StringID>>(fxMarkerStart, name: "fxMarkerStart");
			fxMarkerStop = s.SerializeObject<CListO<StringID>>(fxMarkerStop, name: "fxMarkerStop");
			lightningStart = s.SerializeObject<StringID>(lightningStart, name: "lightningStart");
			lightningStop = s.SerializeObject<StringID>(lightningStop, name: "lightningStop");
			lightningCharge = s.SerializeObject<StringID>(lightningCharge, name: "lightningCharge");
			useShakeCamera = s.Serialize<bool>(useShakeCamera, name: "useShakeCamera");
			canMemorizeHitWithDuration = s.Serialize<bool>(canMemorizeHitWithDuration, name: "canMemorizeHitWithDuration");
			memorizeHitDuration = s.Serialize<float>(memorizeHitDuration, name: "memorizeHitDuration");
		}
		[Games(GameFlags.RA)]
		public partial class AttackData : CSerializable {
			public PUNCHTYPE punchType = PUNCHTYPE.REPEATING;
			public uint level;
			public float pushBackRadius;
			public float duration;
			public StringID anim;
			public bool updateHitShape;
			public bool canUseAnimationRootDelta;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				punchType = s.Serialize<PUNCHTYPE>(punchType, name: "punchType");
				level = s.Serialize<uint>(level, name: "level");
				pushBackRadius = s.Serialize<float>(pushBackRadius, name: "pushBackRadius");
				duration = s.Serialize<float>(duration, name: "duration");
				anim = s.SerializeObject<StringID>(anim, name: "anim");
				updateHitShape = s.Serialize<bool>(updateHitShape, name: "updateHitShape");
				canUseAnimationRootDelta = s.Serialize<bool>(canUseAnimationRootDelta, name: "canUseAnimationRootDelta");
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

