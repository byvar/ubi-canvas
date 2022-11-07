namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventEnableShadow : Event {
		public bool Enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.VH || s.Settings.game == Settings.Game.RA || s.Settings.game == Settings.Game.RM) {
				Enable = s.Serialize<bool>(Enable, name: "Enable");
			}
		}
		public override uint? ClassCRC => 0xF1CB5691;
	}
}

