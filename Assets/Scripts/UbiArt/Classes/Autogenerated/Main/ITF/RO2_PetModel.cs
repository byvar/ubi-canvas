using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_PetModel : CSerializable {
		[Serialize("familyID"        )] public int familyID;
		[Serialize("animPetDataIndex")] public int animPetDataIndex;
		[Serialize("randomCoef"      )] public uint randomCoef;
		[Serialize("tag"             )] public StringID tag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(familyID));
			SerializeField(s, nameof(animPetDataIndex));
			SerializeField(s, nameof(randomCoef));
			SerializeField(s, nameof(tag));
		}
	}
}

