using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventWiki : Event {
		[Serialize("bool__0")] public bool bool__0;
		[Serialize("uint__1")] public uint uint__1;
		[Serialize("uint__2")] public uint uint__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(uint__1));
			SerializeField(s, nameof(uint__2));
		}
		public override uint? ClassCRC => 0xF8CB5796;
	}
}

