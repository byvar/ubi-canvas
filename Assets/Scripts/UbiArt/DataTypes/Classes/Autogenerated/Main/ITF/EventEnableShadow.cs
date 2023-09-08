namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventEnableShadow : Event {
		public bool Enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.VH || s.Settings.Game == Game.RA || s.Settings.Game == Game.RM) {
				Enable = s.Serialize<bool>(Enable, name: "Enable");
			}
		}
		public override uint? ClassCRC => 0xF1CB5691;
	}
}

