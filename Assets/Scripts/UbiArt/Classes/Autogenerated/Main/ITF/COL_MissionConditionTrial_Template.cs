using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionConditionTrial_Template : CSerializable {
		public bool negated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			negated = s.Serialize<bool>(negated, name: "negated", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x52506CB1;
	}
}

