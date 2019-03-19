using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionSetProgress_Template : CSerializable {
		[Serialize("progress")] public float progress;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(progress));
		}
		public override uint? ClassCRC => 0x0962D937;
	}
}

