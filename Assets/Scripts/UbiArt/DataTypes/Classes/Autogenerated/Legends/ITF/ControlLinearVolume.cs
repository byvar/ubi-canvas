namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class ControlLinearVolume : SoundModifier {
		public ProceduralInputData input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			input = s.SerializeObject<ProceduralInputData>(input, name: "input");
		}
		public override uint? ClassCRC => 0x42FD73DC;
	}
}

