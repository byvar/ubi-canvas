namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class PlayText_evt : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD2B20F07;
	}
}

