using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventShieldGlobalActivation : Event {
		public bool activation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activation = s.Serialize<bool>(activation, name: "activation");
		}
		public override uint? ClassCRC => 0x5B896E39;
	}
}

