namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_469_sub_B93970 : CSerializable {
		public StringID bounceBallonInput;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bounceBallonInput = s.SerializeObject<StringID>(bounceBallonInput, name: "bounceBallonInput");
		}
		public override uint? ClassCRC => 0xDF92872F;
	}
}

