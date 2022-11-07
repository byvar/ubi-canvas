namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_DisplayTutoIconKillerComponent : ActorComponent {
		public bool Disable_Main_Type;
		public bool Disable_DRC_Type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Disable_Main_Type = s.Serialize<bool>(Disable_Main_Type, name: "Disable_Main_Type");
			Disable_DRC_Type = s.Serialize<bool>(Disable_DRC_Type, name: "Disable_DRC_Type");
		}
		public override uint? ClassCRC => 0x897604E4;
	}
}

