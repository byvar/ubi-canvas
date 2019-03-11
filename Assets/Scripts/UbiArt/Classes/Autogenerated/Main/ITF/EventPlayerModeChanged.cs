using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventPlayerModeChanged : EventTrigger {
		[Serialize("mode")] public uint mode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(mode));
		}
		public override uint? ClassCRC => 0x4FAB9E6B;
	}
}

