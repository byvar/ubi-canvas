namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionHitTarget_Template : BTAction_Template {
		public CListO<Ray_BTActionHitTarget_Template.AttackData> attacks;
		public StringID fxBoneName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			attacks = s.SerializeObject<CListO<Ray_BTActionHitTarget_Template.AttackData>>(attacks, name: "attacks");
			fxBoneName = s.SerializeObject<StringID>(fxBoneName, name: "fxBoneName");
		}

		[Games(GameFlags.RO)]
		public partial class AttackData : CSerializable {
			public PUNCHTYPE punchType;
			public uint level;
			public float pushBackRadius;
			public float duration;
			public StringID anim;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				punchType = s.Serialize<PUNCHTYPE>(punchType, name: "punchType");
				level = s.Serialize<uint>(level, name: "level");
				pushBackRadius = s.Serialize<float>(pushBackRadius, name: "pushBackRadius");
				duration = s.Serialize<float>(duration, name: "duration");
				anim = s.SerializeObject<StringID>(anim, name: "anim");
			}
			public enum PUNCHTYPE {
				[Serialize("PUNCHTYPE_CHARGE")] CHARGE = 0,
				[Serialize("PUNCHTYPE_CRUSH")] CRUSH = 1,
				[Serialize("PUNCHTYPE_CROUCHKICK")] CROUCHKICK = 2,
				[Serialize("PUNCHTYPE_TORNADO")] TORNADO = 3,
				[Serialize("PUNCHTYPE_REPEATING")] REPEATING = 4,
				[Serialize("PUNCHTYPE_SPIN")] SPIN = 5,
				[Serialize("PUNCHTYPE_TORNADOZIP")] TORNADOZIP = 6,
				[Serialize("PUNCHTYPE_UTURNKICK")] UTURNKICK = 7,
				[Serialize("PUNCHTYPE_UPPERKICK")] UPPERKICK = 9,
			}
		}
		public override uint? ClassCRC => 0x5EC4226C;
	}
}

