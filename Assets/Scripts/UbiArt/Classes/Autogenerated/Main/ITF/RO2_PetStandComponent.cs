using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PetStandComponent : ActorComponent {
		public uint familyID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			familyID = s.Serialize<uint>(familyID, name: "familyID");
		}
		public override uint? ClassCRC => 0x381FCFA9;
	}
}

