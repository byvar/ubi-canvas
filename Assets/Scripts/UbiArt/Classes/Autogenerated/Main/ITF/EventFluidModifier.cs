using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventFluidModifier : Event {
		public bool activated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activated = s.Serialize<bool>(activated, name: "activated");
		}
		public override uint? ClassCRC => 0xB8C04557;
	}
}

