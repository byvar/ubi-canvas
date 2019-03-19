using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class EventZoneTrigger : EventTrigger {
		[Serialize("zoneID")] public StringID zoneID;
		[Serialize("radius")] public float radius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(zoneID));
			SerializeField(s, nameof(radius));
		}
		public override uint? ClassCRC => 0x0A53E648;
	}
}

