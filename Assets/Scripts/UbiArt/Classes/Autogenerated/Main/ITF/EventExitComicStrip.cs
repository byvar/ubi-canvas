using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class EventExitComicStrip : Event {
		[Serialize("uint__0")] public uint uint__0;
		[Serialize("uint__1")] public uint uint__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
			SerializeField(s, nameof(uint__1));
		}
		public override uint? ClassCRC => 0x695D55A5;
	}
}

