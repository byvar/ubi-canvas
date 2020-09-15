using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class TrajectoryNodeComponent_Template : ActorComponent_Template {
		public bool useCurvedEnd;
		public bool useDrawDebug;
		public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL && this is RO2_SnakeNetworkNodeComponent_Template) return;
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
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

