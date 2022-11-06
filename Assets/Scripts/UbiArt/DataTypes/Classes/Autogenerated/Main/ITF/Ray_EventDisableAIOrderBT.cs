using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_EventDisableAIOrderBT : Event {
		public int disable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			disable = s.Serialize<int>(disable, name: "disable");
		}
		public override uint? ClassCRC => 0xA4151B1F;
	}
}

