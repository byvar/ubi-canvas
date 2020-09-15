using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventDragonDeathZoneActivation : Event {
		public bool Activation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Activation = s.Serialize<bool>(Activation, name: "Activation");
		}
		public override uint? ClassCRC => 0xFD0E1D11;
	}
}

