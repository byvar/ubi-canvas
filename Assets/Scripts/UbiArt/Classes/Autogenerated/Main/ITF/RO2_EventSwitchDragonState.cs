using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventSwitchDragonState : Event {
		[Serialize("DragonState")] public uint DragonState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DragonState));
		}
		public override uint? ClassCRC => 0x967EE149;
	}
}

