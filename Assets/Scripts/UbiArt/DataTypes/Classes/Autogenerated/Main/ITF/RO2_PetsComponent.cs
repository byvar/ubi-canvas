namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PetsComponent : GraphicComponent {
		public bool AllAtStart;
		public RO2_PetSimulation PetsSimulation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			AllAtStart = s.Serialize<bool>(AllAtStart, name: "AllAtStart");
			PetsSimulation = s.SerializeObject<RO2_PetSimulation>(PetsSimulation, name: "PetsSimulation");
		}
		public override uint? ClassCRC => 0xB2C46183;
	}
}

