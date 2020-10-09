using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventLAN_GPE : Event {
		public StringID ID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ID = s.SerializeObject<StringID>(ID, name: "ID");
		}
		public override uint? ClassCRC => 0xB3F18017;
	}
}

