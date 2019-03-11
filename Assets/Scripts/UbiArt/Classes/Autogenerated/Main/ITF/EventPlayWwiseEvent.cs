using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventPlayWwiseEvent : SendMetronomedEvent {
		[Serialize("WwiseEventGUID"              )] public StringID WwiseEventGUID;
		[Serialize("EventGUIDBackupSerialization")] public StringID EventGUIDBackupSerialization;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(WwiseEventGUID));
			SerializeField(s, nameof(EventGUIDBackupSerialization));
		}
		public override uint? ClassCRC => 0xFDDFC049;
	}
}

