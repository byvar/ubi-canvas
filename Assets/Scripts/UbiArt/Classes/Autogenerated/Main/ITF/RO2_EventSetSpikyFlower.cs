using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventSetSpikyFlower : Event {
		[Serialize("circleIndex")] public uint circleIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(circleIndex));
		}
		public override uint? ClassCRC => 0x3FE138B3;
	}
}

