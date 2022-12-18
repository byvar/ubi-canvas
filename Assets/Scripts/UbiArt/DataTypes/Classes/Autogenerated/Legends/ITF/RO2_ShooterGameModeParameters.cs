namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterGameModeParameters : RO2_GameModeParameters {
		public bool activateModeOnFirstActivation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activateModeOnFirstActivation = s.Serialize<bool>(activateModeOnFirstActivation, name: "activateModeOnFirstActivation", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x572E39FF;
	}
}

