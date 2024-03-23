namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_NPCAIData : CSerializable {
		[Description("Type of the NPC")]
		public Enum_npcType npcType;
		public bool useRoaming;
		public float roamingLimitLeft;
		public float roamingLimitRight;
		public bool roamingVertical;
		public bool m_roamingCanChangePolylines;
		public bool useFollowCurve;
		public bool useAlerted;
		public bool useCharge;
		public float chargeLimitLeft;
		public float chargeLimitRight;
		public float chargeSpeed;
		public bool useStun;
		public bool useRangeAttack;
		public float maxAbsoluteAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				npcType = s.Serialize<Enum_npcType>(npcType, name: "npcType");
				useRoaming = s.Serialize<bool>(useRoaming, name: "useRoaming", options: CSerializerObject.Options.BoolAsByte);
				roamingLimitLeft = s.Serialize<float>(roamingLimitLeft, name: "roamingLimitLeft");
				roamingLimitRight = s.Serialize<float>(roamingLimitRight, name: "roamingLimitRight");
				roamingVertical = s.Serialize<bool>(roamingVertical, name: "roamingVertical", options: CSerializerObject.Options.BoolAsByte);
				m_roamingCanChangePolylines = s.Serialize<bool>(m_roamingCanChangePolylines, name: "m_roamingCanChangePolylines", options: CSerializerObject.Options.BoolAsByte);
				useFollowCurve = s.Serialize<bool>(useFollowCurve, name: "useFollowCurve", options: CSerializerObject.Options.BoolAsByte);
				useAlerted = s.Serialize<bool>(useAlerted, name: "useAlerted", options: CSerializerObject.Options.BoolAsByte);
				useCharge = s.Serialize<bool>(useCharge, name: "useCharge", options: CSerializerObject.Options.BoolAsByte);
				chargeLimitLeft = s.Serialize<float>(chargeLimitLeft, name: "chargeLimitLeft");
				chargeLimitRight = s.Serialize<float>(chargeLimitRight, name: "chargeLimitRight");
				chargeSpeed = s.Serialize<float>(chargeSpeed, name: "chargeSpeed");
				useStun = s.Serialize<bool>(useStun, name: "useStun", options: CSerializerObject.Options.BoolAsByte);
				useRangeAttack = s.Serialize<bool>(useRangeAttack, name: "useRangeAttack", options: CSerializerObject.Options.BoolAsByte);
				maxAbsoluteAngle = s.Serialize<float>(maxAbsoluteAngle, name: "maxAbsoluteAngle");
			}
		}
		public enum Enum_npcType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x712EFFF5;
	}
}

