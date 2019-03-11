using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventNoHit : Event {
		[Serialize("activateNoHit")] public bool activateNoHit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activateNoHit));
		}
		public override uint? ClassCRC => 0x727932AF;
	}
}

