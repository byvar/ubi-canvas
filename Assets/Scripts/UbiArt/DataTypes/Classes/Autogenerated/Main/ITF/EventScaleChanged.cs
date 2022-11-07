namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class EventScaleChanged : CSerializable {
		public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO) {
				sender = s.Serialize<uint>(sender, name: "sender");
			} else {
			}
		}
		public override uint? ClassCRC => 0xD862CFC6;
	}
}

