using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.VH)]
	public partial class BoolEventList : CSerializable {
		[Serialize("Keys")] public CList<BoolEventList.BoolEvent> Keys;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Keys));
		}
		[Games(GameFlags.RA | GameFlags.RFR | GameFlags.VH)]
		public partial class BoolEvent : CSerializable {
			[Serialize("value")] public bool value;
			[Serialize("Frame")] public int Frame;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(value));
				SerializeField(s, nameof(Frame));
			}
		}
	}
}

