using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SinglePetComponent : GraphicComponent {
		public PetProfile petProfile;
		public bool isPetStatic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			petProfile = s.SerializeObject<PetProfile>(petProfile, name: "petProfile");
			isPetStatic = s.Serialize<bool>(isPetStatic, name: "isPetStatic");
		}
		public override uint? ClassCRC => 0xE2C1C7C5;
	}
}

