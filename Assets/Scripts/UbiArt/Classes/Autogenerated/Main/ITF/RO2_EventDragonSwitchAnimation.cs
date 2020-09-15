using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventDragonSwitchAnimation : Event {
		public StringID Animation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Animation = s.SerializeObject<StringID>(Animation, name: "Animation");
		}
		public override uint? ClassCRC => 0xF954098D;
	}
}

