namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class PlayInput_evt : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8534A7DD;
	}
}

