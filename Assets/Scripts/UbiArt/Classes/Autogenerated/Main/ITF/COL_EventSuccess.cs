using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventSuccess : Event {
		public uint index;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			index = s.Serialize<uint>(index, name: "index");
		}
		public override uint? ClassCRC => 0x8A276CA1;
	}
}

