using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventSetSpikyFlower : Event {
		[Serialize("circleIndex")] public uint circleIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(circleIndex));
		}
		public override uint? ClassCRC => 0xF688194E;
	}
}

