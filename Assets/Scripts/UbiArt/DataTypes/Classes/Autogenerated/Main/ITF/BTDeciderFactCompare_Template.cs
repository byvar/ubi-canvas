namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class BTDeciderFactCompare_Template : BTDecider_Template {
		public StringID fact;
		public string value;
		public EValueType type;
		public ECompareType compare;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fact = s.SerializeObject<StringID>(fact, name: "fact");
			value = s.Serialize<string>(value, name: "value");
			type = s.Serialize<EValueType>(type, name: "type");
			compare = s.Serialize<ECompareType>(compare, name: "compare");
		}
		public enum EValueType {
			[Serialize("EValueType_Unknown"   )] Unknown = 0,
			[Serialize("EValueType_Boolean"   )] Boolean = 1,
			[Serialize("EValueType_Integer32" )] Integer32 = 2,
			[Serialize("EValueType_UInteger32")] UInteger32 = 3,
			[Serialize("EValueType_Float"     )] Float = 4,
			[Serialize("EValueType_StringId"  )] StringId = 5,
			[Serialize("EValueType_Vec2"      )] Vec2 = 6,
			[Serialize("EValueType_Vec3"      )] Vec3 = 7,
			[Serialize("EValueType_ObjectRef" )] ObjectRef = 8,
			[Serialize("EValueType_Event"     )] Event = 9,
		}
		public enum ECompareType {
			[Serialize("ECompareType_GreaterThan" )] GreaterThan = 1,
			[Serialize("ECompareType_GreaterEqual")] GreaterEqual = 2,
			[Serialize("ECompareType_Equal"       )] Equal = 3,
			[Serialize("ECompareType_LesserEqual" )] LesserEqual = 4,
			[Serialize("ECompareType_LesserThan"  )] LesserThan = 5,
		}
		public override uint? ClassCRC => 0x13FAB172;
	}
}

