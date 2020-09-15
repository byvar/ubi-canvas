using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventFailure : Event {
		public uint index;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			index = s.Serialize<uint>(index, name: "index");
		}
		public override uint? ClassCRC => 0x47D69873;
	}
}

