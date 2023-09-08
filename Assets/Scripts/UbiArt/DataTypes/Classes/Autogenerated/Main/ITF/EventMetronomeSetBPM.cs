namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.RA | GameFlags.RM)]
	public partial class EventMetronomeSetBPM : Event {
		public uint bpm;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO 
				|| s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				bpm = s.Serialize<uint>(bpm, name: "bpm");
			} else {
			}
		}
		public override uint? ClassCRC => 0x444B5170;
	}
}

