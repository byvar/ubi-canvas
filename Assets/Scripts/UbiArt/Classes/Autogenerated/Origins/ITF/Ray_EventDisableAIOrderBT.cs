using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventDisableAIOrderBT : Event {
		[Serialize("disable")] public bool disable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(disable));
		}
		public override uint? ClassCRC => 0xA4151B1F;
	}
}

