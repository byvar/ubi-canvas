using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class BTDeciderDistance_Template : BTDecider_Template {
		public float distance;
		public ECompareType type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			distance = s.Serialize<float>(distance, name: "distance");
			type = s.Serialize<ECompareType>(type, name: "type");
		}
		public enum ECompareType {
			[Serialize("ECompareType_GreaterThan" )] GreaterThan = 1,
			[Serialize("ECompareType_GreaterEqual")] GreaterEqual = 2,
			[Serialize("ECompareType_Equal"       )] Equal = 3,
			[Serialize("ECompareType_LesserEqual" )] LesserEqual = 4,
			[Serialize("ECompareType_LesserThan"  )] LesserThan = 5,
		}
		public override uint? ClassCRC => 0x6CC505E5;
	}
}

