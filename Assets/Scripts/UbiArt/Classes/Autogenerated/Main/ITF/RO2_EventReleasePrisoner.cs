using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventReleasePrisoner : Event {
		[Serialize("investigator")] public ObjectRef investigator;
		[Serialize("ownerIsDead" )] public bool ownerIsDead;
		[Serialize("investigator")] public uint investigator;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(investigator));
				SerializeField(s, nameof(ownerIsDead));
			} else {
				SerializeField(s, nameof(investigator));
				SerializeField(s, nameof(ownerIsDead));
			}
		}
		public override uint? ClassCRC => 0xB233A40F;
	}
}

