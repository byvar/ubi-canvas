namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class LogStatHandler : StatHandler {
		public Generic<IStatParser> Parser;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Parser = s.SerializeObject<Generic<IStatParser>>(Parser, name: "Parser");
		}
		public override uint? ClassCRC => 0x41BF63EE;
	}
}

