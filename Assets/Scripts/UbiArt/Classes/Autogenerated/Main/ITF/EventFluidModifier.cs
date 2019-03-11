using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventFluidModifier : Event {
		[Serialize("activated")] public bool activated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activated));
		}
		public override uint? ClassCRC => 0xB8C04557;
	}
}

