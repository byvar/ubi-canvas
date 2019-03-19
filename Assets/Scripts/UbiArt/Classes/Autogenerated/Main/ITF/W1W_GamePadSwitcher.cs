using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_GamePadSwitcher : ActorComponent {
		[Serialize("StringID__0")] public StringID StringID__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
		}
		public override uint? ClassCRC => 0xA20E93EA;
	}
}

