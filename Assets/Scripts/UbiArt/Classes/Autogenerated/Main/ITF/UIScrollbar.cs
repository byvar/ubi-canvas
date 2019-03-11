using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIScrollbar : UIComponent {
		[Serialize("textBoxFriendly")] public StringID textBoxFriendly;
		[Serialize("speed"          )] public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(textBoxFriendly));
				SerializeField(s, nameof(speed));
			}
		}
		public override uint? ClassCRC => 0x6B682541;
	}
}

