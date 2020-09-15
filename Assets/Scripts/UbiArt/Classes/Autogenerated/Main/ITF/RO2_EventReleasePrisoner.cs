using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventReleasePrisoner : Event {
		public ObjectRef investigator;
		public bool ownerIsDead;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				investigator = (ObjectRef)s.Serialize<uint>((uint)investigator, name: "investigator");
				ownerIsDead = s.Serialize<bool>(ownerIsDead, name: "ownerIsDead");
			} else {
				investigator = s.SerializeObject<ObjectRef>(investigator, name: "investigator");
				ownerIsDead = s.Serialize<bool>(ownerIsDead, name: "ownerIsDead");
			}
		}
		public override uint? ClassCRC => 0xB233A40F;
	}
}

