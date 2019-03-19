using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_EventDisableAIOrderBT : Event {
		[Serialize("disable")] public int disable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(disable));
		}
		public override uint? ClassCRC => 0xA4151B1F;
	}
}

