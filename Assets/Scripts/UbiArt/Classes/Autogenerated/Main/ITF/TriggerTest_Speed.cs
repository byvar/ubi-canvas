using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class TriggerTest_Speed : TriggerTestAbstract {
		[Serialize("SpeedValue"    )] public float SpeedValue;
		[Serialize("HorizontalTest")] public bool HorizontalTest;
		[Serialize("Operator"      )] public ECompareType Operator;
		[Serialize("ActorNbrMin"   )] public uint ActorNbrMin;
		[Serialize("float__0"      )] public float float__0;
		[Serialize("Enum_VH_0__1"  )] public Enum_VH_0 Enum_VH_0__1;
		[Serialize("uint__2"       )] public uint uint__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(Enum_VH_0__1));
				SerializeField(s, nameof(uint__2));
			} else {
				SerializeField(s, nameof(SpeedValue));
				SerializeField(s, nameof(HorizontalTest));
				SerializeField(s, nameof(Operator));
				SerializeField(s, nameof(ActorNbrMin));
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

