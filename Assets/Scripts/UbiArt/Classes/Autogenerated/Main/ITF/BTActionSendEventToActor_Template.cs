using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTActionSendEventToActor_Template : BTAction_Template {
		[Serialize("target")] public StringID target;
		[Serialize("event" )] public Generic<Event> _event;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(target));
			SerializeField(s, nameof(_event));
		}
		public override uint? ClassCRC => 0xF5050E97;
	}
}

