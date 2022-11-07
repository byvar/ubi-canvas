namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class RelayEventComponent : ActorComponent {
		public CListO<RelayData> relays;
		public bool receiveBroadcast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.VH) {
				relays = s.SerializeObject<CListO<RelayData>>(relays, name: "relays");
			} else if(s.Settings.game == Settings.Game.RA || s.Settings.game == Settings.Game.RM) {
				relays = s.SerializeObject<CListO<RelayData>>(relays, name: "relays");
				receiveBroadcast = s.Serialize<bool>(receiveBroadcast, name: "receiveBroadcast");
			}
		}
		public override uint? ClassCRC => 0x7291EA2B;
	}
}

