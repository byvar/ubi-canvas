using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class SoundBusControllerComponent : CSerializable {
		[Serialize("busData")] public Placeholder busData;
		[Serialize("inputs" )] public Placeholder inputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(busData));
			SerializeField(s, nameof(inputs));
		}
		public override uint? ClassCRC => 0xAFFF34B3;
	}
}

