using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class EventPlayerModeSet : Event {
		[Serialize("mode")] public uint mode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(mode));
		}
		public override uint? ClassCRC => 0x2B16A294;
	}
}

