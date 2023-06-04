namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class PlayCheckInput_evt : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF85C97C7;
	}
}

