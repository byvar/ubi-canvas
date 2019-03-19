using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class MarkerEvent : CSerializable {
		[Serialize("marker")] public StringID marker;
		[Serialize("event" )] public Generic<Event> _event;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(marker));
			SerializeField(s, nameof(_event));
		}
	}
}

