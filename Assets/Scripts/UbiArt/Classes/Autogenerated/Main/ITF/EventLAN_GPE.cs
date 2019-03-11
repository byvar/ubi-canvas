using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventLAN_GPE : Event {
		[Serialize("ID")] public StringID ID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ID));
		}
		public override uint? ClassCRC => 0xB3F18017;
	}
}

