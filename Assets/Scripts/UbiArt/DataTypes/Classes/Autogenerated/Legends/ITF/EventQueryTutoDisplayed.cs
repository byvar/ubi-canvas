namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class EventQueryTutoDisplayed : CSerializable {
		public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				sender = s.Serialize<uint>(sender, name: "sender");
			} else {
			}
		}
		public override uint? ClassCRC => 0x5375ABEE;
	}
}

