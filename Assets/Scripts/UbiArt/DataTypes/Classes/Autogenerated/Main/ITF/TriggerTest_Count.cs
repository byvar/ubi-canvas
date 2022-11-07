namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class TriggerTest_Count : TriggerTestAbstract {
		public uint ValueRef;
		public ECompareType Operator;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ValueRef = s.Serialize<uint>(ValueRef, name: "ValueRef");
			Operator = s.Serialize<ECompareType>(Operator, name: "Operator");
		}
		public enum ECompareType {
			[Serialize("ECompareType_GreaterThan" )] GreaterThan = 1,
			[Serialize("ECompareType_GreaterEqual")] GreaterEqual = 2,
			[Serialize("ECompareType_Equal"       )] Equal = 3,
			[Serialize("ECompareType_LesserEqual" )] LesserEqual = 4,
			[Serialize("ECompareType_LesserThan"  )] LesserThan = 5,
		}
		public override uint? ClassCRC => 0xAC99AA79;
	}
}

