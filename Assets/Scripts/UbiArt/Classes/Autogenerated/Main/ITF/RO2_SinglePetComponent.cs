using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SinglePetComponent : GraphicComponent {
		[Serialize("petProfile" )] public PetProfile petProfile;
		[Serialize("isPetStatic")] public bool isPetStatic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(petProfile));
			SerializeField(s, nameof(isPetStatic));
		}
		public override uint? ClassCRC => 0xE2C1C7C5;
	}
}

