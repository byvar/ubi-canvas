using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventReleasePrisoner : Event {
		[Serialize("investigator")] public ObjectRef investigator;
		[Serialize("ownerIsDead" )] public bool ownerIsDead;
		[Serialize("investigator")] public uint investigator;
		[Serialize("bool__0"     )] public bool bool__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(investigator));
				SerializeField(s, nameof(ownerIsDead));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(bool__0));
			} else {
				SerializeField(s, nameof(investigator));
				SerializeField(s, nameof(ownerIsDead));
			}
		}
		public override uint? ClassCRC => 0xB233A40F;
	}
}

