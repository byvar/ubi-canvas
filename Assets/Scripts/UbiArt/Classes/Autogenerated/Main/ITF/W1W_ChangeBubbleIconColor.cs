using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ChangeBubbleIconColor : Event {
		[Serialize("Color__0")] public Color Color__0;
		[Serialize("uint__1" )] public uint uint__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Color__0));
			SerializeField(s, nameof(uint__1));
		}
		public override uint? ClassCRC => 0x9CA8940B;
	}
}

