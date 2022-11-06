using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_WindComponent : CSerializable {
		public Placeholder windAreas;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			windAreas = s.SerializeObject<Placeholder>(windAreas, name: "windAreas");
		}
		public override uint? ClassCRC => 0x7DABAD2D;
	}
}

