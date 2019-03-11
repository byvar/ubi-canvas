using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventHUDSetText : Event {
		[Serialize("friendlyName")] public string friendlyName;
		[Serialize("text"        )] public string text;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(friendlyName));
			SerializeField(s, nameof(text));
		}
		public override uint? ClassCRC => 0x4FE65042;
	}
}

