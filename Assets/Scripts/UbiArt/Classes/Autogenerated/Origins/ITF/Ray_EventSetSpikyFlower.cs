using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventSetSpikyFlower : CSerializable {
		[Serialize("circleIndex")] public uint circleIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(circleIndex));
		}
		public override uint? ClassCRC => 0xF688194E;
	}
}

