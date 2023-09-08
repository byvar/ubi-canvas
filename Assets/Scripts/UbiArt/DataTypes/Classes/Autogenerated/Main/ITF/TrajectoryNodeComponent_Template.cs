namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class TrajectoryNodeComponent_Template : ActorComponent_Template {
		public bool useCurvedEnd = true;
		public bool useDrawDebug = true;
		public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL && this is RO2_SnakeNetworkNodeComponent_Template) return;
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO || s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				useCurvedEnd = s.Serialize<bool>(useCurvedEnd, name: "useCurvedEnd");
				name = s.SerializeObject<StringID>(name, name: "name");
			} else {
				useCurvedEnd = s.Serialize<bool>(useCurvedEnd, name: "useCurvedEnd");
				useDrawDebug = s.Serialize<bool>(useDrawDebug, name: "useDrawDebug");
				name = s.SerializeObject<StringID>(name, name: "name");
			}
		}
		public override uint? ClassCRC => 0x040C7328;
	}
}

