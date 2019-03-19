using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_AnimatedWindComponent_Template : CSerializable {
		[Serialize("windAreas")] public Placeholder windAreas;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(windAreas));
		}
		public override uint? ClassCRC => 0x74350568;
	}
}

