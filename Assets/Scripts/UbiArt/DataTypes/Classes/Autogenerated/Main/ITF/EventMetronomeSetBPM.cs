namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.RA | GameFlags.RM)]
	public partial class EventMetronomeSetBPM : Event {
		public uint bpm;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO 
				|| s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				bpm = s.Serialize<uint>(bpm, name: "bpm");
			} else {
			}
		}
		public override uint? ClassCRC => 0x444B5170;
	}
}

