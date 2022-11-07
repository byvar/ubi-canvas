namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class CSVStatParser : IStatParser {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7DAFAE4C;
	}
}

