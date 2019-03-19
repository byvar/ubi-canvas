using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionConditionTrial_Template : CSerializable {
		[Serialize("negated")] public bool negated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(negated), boolAsByte: true);
		}
		public override uint? ClassCRC => 0x52506CB1;
	}
}

