namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventWantViewDRC : Event {
		public bool wantView;
		public bool cut;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			wantView = s.Serialize<bool>(wantView, name: "wantView");
			if (s.Settings.platform != Settings.Platform.Vita) {
				cut = s.Serialize<bool>(cut, name: "cut");
			}
		}
		public override uint? ClassCRC => 0x762E1E4B;
	}
}

