using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventAchievement : Event {
		[Serialize("StringID__0")] public StringID StringID__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
		}
		public override uint? ClassCRC => 0xD8B0158C;
	}
}

