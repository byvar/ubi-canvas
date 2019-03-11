using UnityEngine;

namespace UbiArt.ITF {
	public partial class TriggerTest_Accumulate : TriggerTestAbstract {
		[Serialize("ValueRef")] public uint ValueRef;
		[Serialize("Operator")] public ECompareType Operator;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ValueRef));
			SerializeField(s, nameof(Operator));
		}
		public enum ECompareType {
			[Serialize("ECompareType_GreaterThan" )] GreaterThan = 1,
			[Serialize("ECompareType_GreaterEqual")] GreaterEqual = 2,
			[Serialize("ECompareType_Equal"       )] Equal = 3,
			[Serialize("ECompareType_LesserEqual" )] LesserEqual = 4,
			[Serialize("ECompareType_LesserThan"  )] LesserThan = 5,
		}
		public override uint? ClassCRC => 0x83F15BFD;
	}
}

