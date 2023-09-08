namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class ZInputConfig_Template : TemplateObj {
		public CArrayO<Path> inputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL || s.Settings.Game == Game.VH) {
				inputs = s.SerializeObject<CArrayO<Path>>(inputs, name: "inputs");
			} else {
			}
		}
		public override uint? ClassCRC => 0x9C26194D;
	}
}

