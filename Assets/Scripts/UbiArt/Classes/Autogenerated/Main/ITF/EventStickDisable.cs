using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventStickDisable : Event {
		[Serialize("Disable")] public bool Disable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Disable));
		}
		public override uint? ClassCRC => 0xBB2DF121;
	}
}

