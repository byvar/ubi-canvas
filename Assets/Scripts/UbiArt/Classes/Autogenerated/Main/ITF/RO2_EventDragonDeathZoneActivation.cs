using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventDragonDeathZoneActivation : Event {
		[Serialize("Activation")] public bool Activation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Activation));
		}
		public override uint? ClassCRC => 0xFD0E1D11;
	}
}

