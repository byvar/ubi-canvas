using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventDigEnable : Event {
		[Serialize("enable")] public bool enable;
		[Serialize("radius")] public float radius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enable));
			SerializeField(s, nameof(radius));
		}
		public override uint? ClassCRC => 0xAD06DCD9;
	}
}

