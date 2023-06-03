namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RO2_GameScreen : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4C6F0092;
	}
}

