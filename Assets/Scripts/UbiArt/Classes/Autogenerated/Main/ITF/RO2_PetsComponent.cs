using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PetsComponent : GraphicComponent {
		[Serialize("AllAtStart"    )] public bool AllAtStart;
		[Serialize("PetsSimulation")] public RO2_PetSimulation PetsSimulation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(AllAtStart));
			SerializeField(s, nameof(PetsSimulation));
		}
		public override uint? ClassCRC => 0xB2C46183;
	}
}

