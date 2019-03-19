using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class RelayEventInstanceComponent : CSerializable {
		[Serialize("resetEvent")] public Placeholder resetEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(resetEvent));
		}
		public override uint? ClassCRC => 0xE44E2592;
	}
}

