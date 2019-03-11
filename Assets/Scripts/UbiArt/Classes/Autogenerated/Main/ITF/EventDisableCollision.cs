using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventDisableCollision : Event {
		[Serialize("disable")] public bool disable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(disable));
		}
		public override uint? ClassCRC => 0xE02F4F4A;
	}
}

