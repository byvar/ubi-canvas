using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventDarkRayman : Event {
		[Serialize("activateDelaySec")] public float activateDelaySec;
		[Serialize("attackOwner"     )] public bool attackOwner;
		[Serialize("attackOthers"    )] public bool attackOthers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activateDelaySec));
			SerializeField(s, nameof(attackOwner));
			SerializeField(s, nameof(attackOthers));
		}
		public override uint? ClassCRC => 0x6F598F25;
	}
}

