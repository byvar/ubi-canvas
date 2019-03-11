using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventTicklePrisoner : Event {
		[Serialize("start")] public bool start;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(start));
		}
		public override uint? ClassCRC => 0x455A3DEC;
	}
}

