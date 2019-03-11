using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventFxScreen : Event {
		[Serialize("isStart" )] public uint isStart;
		[Serialize("fadeType")] public StringID fadeType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isStart));
			SerializeField(s, nameof(fadeType));
		}
		public override uint? ClassCRC => 0x159E0C37;
	}
}

