namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class SaveNotificationComponent : ActorComponent {
		public CListP<uint> saveReasons;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RA || s.Settings.Game == Game.RM || s.Settings.Game == Game.VH) {
				saveReasons = s.SerializeObject<CListP<uint>>(saveReasons, name: "saveReasons");
			}
		}
		public override uint? ClassCRC => 0xF66490C1;
	}
}

