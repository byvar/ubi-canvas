using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventMonitorComponent : CSerializable {
		[Serialize("numToMonitor")] public uint numToMonitor;
		[Serialize("successEvent")] public Placeholder successEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(numToMonitor));
			SerializeField(s, nameof(successEvent));
		}
		public override uint? ClassCRC => 0xA821D824;
	}
}

