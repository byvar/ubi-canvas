namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_GS_Init : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCFA8C0CA;
	}
}

