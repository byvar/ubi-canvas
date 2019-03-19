using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionStepCinematicDialog_Template : CSerializable {
		[Serialize("data")] public Placeholder data;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(data));
		}
		public override uint? ClassCRC => 0x8F77242E;
	}
}

