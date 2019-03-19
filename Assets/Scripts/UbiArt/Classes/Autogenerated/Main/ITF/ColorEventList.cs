using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ColorEventList : CSerializable {
		[Serialize("Keys")] public CList<ColorEventList.ColorEvent> Keys;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Keys));
		}
		[Games(GameFlags.RA)]
		public partial class ColorEvent : CSerializable {
			[Serialize("value")] public uint value;
			[Serialize("Frame")] public int Frame;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(value));
				SerializeField(s, nameof(Frame));
			}
		}
	}
}

