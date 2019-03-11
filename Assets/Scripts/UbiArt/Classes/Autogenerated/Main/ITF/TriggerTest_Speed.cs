using UnityEngine;

namespace UbiArt.ITF {
	public partial class TriggerTest_Speed : TriggerTestAbstract {
		[Serialize("SpeedValue"    )] public float SpeedValue;
		[Serialize("HorizontalTest")] public bool HorizontalTest;
		[Serialize("Operator"      )] public ECompareType Operator;
		[Serialize("ActorNbrMin"   )] public uint ActorNbrMin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(SpeedValue));
			SerializeField(s, nameof(HorizontalTest));
			SerializeField(s, nameof(Operator));
			SerializeField(s, nameof(ActorNbrMin));
		}
		public enum ECompareType {
			[Serialize("ECompareType_GreaterThan" )] GreaterThan = 1,
			[Serialize("ECompareType_GreaterEqual")] GreaterEqual = 2,
			[Serialize("ECompareType_Equal"       )] Equal = 3,
			[Serialize("ECompareType_LesserEqual" )] LesserEqual = 4,
			[Serialize("ECompareType_LesserThan"  )] LesserThan = 5,
		}
		public override uint? ClassCRC => 0xEC8A76E4;
	}
}

