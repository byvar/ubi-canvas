namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class RelayEventComponent_Template : ActorComponent_Template {
		public CListO<ITF.RelayData> relays;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			relays = s.SerializeObject<CListO<ITF.RelayData>>(relays, name: "relays");
		}
		public override uint? ClassCRC => 0x060B7DC1;
	}
}

