using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class EventStopAnim : Event {
		[Serialize("AnimToStop")] public StringID AnimToStop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(AnimToStop));
		}
		public override uint? ClassCRC => 0x58E72E54;
	}
}

