using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionStepPuzzleSolved_Template : CSerializable {
		[Serialize("id")] public Placeholder id;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
		}
		public override uint? ClassCRC => 0x654D4075;
	}
}

