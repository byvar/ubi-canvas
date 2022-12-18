namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterPirateShipAIComponent_Template : CSerializable {
		public StringID bounceBallonInput;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bounceBallonInput = s.SerializeObject<StringID>(bounceBallonInput, name: "bounceBallonInput");
		}
		public override uint? ClassCRC => 0xDF92872F;
	}
}

