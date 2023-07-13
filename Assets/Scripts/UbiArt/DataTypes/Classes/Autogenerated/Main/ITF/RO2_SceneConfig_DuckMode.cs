namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SceneConfig_DuckMode : RO2_SceneConfig_Base {
		public uint Vita_00 { get; set; }
		public uint Vita_01 { get; set; }
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.platform == Settings.Platform.Vita) {
				Vita_00 = s.Serialize<uint>(Vita_00, name: nameof(Vita_00));
				Vita_01 = s.Serialize<uint>(Vita_01, name: nameof(Vita_01));
			}
		}
		public override uint? ClassCRC => 0x4E7F9966;
	}
}

