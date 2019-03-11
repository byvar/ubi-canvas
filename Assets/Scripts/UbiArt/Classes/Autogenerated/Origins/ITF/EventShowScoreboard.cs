using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventShowScoreboard : CSerializable {
		[Serialize("sender" )] public uint sender;
		[Serialize("display")] public bool display;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(display));
		}
		public override uint? ClassCRC => 0xF87620F8;
	}
}

