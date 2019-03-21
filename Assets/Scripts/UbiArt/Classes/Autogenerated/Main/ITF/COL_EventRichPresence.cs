using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventRichPresence : Event {
		[Serialize("presenceIndex")] public uint presenceIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(presenceIndex));
		}
		public override uint? ClassCRC => 0x3C834FC3;
	}
}

