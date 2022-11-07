namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class TriggerTest_Speed : TriggerTestAbstract {
		public float SpeedValue;
		public bool HorizontalTest;
		public ECompareType Operator;
		public uint ActorNbrMin;
		public float float__0;
		public Enum_VH_0 Enum_VH_0__1;
		public uint uint__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.VH) {
				float__0 = s.Serialize<float>(float__0, name: "float__0");
				Enum_VH_0__1 = s.Serialize<Enum_VH_0>(Enum_VH_0__1, name: "Enum_VH_0__1");
				uint__2 = s.Serialize<uint>(uint__2, name: "uint__2");
			} else {
				SpeedValue = s.Serialize<float>(SpeedValue, name: "SpeedValue");
				HorizontalTest = s.Serialize<bool>(HorizontalTest, name: "HorizontalTest");
				Operator = s.Serialize<ECompareType>(Operator, name: "Operator");
				ActorNbrMin = s.Serialize<uint>(ActorNbrMin, name: "ActorNbrMin");
			}
		}
		public enum ECompareType {
			[Serialize("ECompareType_GreaterThan" )] GreaterThan = 1,
			[Serialize("ECompareType_GreaterEqual")] GreaterEqual = 2,
			[Serialize("ECompareType_Equal"       )] Equal = 3,
			[Serialize("ECompareType_LesserEqual" )] LesserEqual = 4,
			[Serialize("ECompareType_LesserThan"  )] LesserThan = 5,
		}
		public enum Enum_VH_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
		}
		public override uint? ClassCRC => 0xEC8A76E4;
	}
}

