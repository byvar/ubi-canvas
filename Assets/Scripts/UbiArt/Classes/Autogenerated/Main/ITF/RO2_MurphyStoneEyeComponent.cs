using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MurphyStoneEyeComponent : RO2_AIComponent {
		[Serialize("activeOnTrigger")] public bool activeOnTrigger;
		[Serialize("activated"      )] public bool activated;
		[Serialize("TimeToRumble"   )] public float TimeToRumble;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(activeOnTrigger));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(activated));
				SerializeField(s, nameof(TimeToRumble));
			}
		}
		public override uint? ClassCRC => 0xB835246A;
	}
}

