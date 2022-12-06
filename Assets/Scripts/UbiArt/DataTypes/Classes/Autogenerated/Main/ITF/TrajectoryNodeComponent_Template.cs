namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class TrajectoryNodeComponent_Template : ActorComponent_Template {
		public bool useCurvedEnd = true;
		public bool useDrawDebug = true;
		public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL && this is RO2_SnakeNetworkNodeComponent_Template) return;
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO || s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
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

