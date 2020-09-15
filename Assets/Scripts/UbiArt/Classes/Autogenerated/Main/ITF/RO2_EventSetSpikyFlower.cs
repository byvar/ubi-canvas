using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventSetSpikyFlower : Event {
		public uint circleIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			circleIndex = s.Serialize<uint>(circleIndex, name: "circleIndex");
		}
		public override uint? ClassCRC => 0x3FE138B3;
	}
}

