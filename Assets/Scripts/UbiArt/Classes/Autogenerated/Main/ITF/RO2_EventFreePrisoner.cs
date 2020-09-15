using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventFreePrisoner : Event {
		public uint index;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			index = s.Serialize<uint>(index, name: "index");
		}
		public override uint? ClassCRC => 0x7E1CF611;
	}
}

