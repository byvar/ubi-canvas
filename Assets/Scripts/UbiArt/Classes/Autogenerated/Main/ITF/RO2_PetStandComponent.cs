using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PetStandComponent : ActorComponent {
		[Serialize("familyID")] public uint familyID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(familyID));
		}
		public override uint? ClassCRC => 0x381FCFA9;
	}
}

