using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class TrajectoryNodeComponent_Template : ActorComponent_Template {
		[Serialize("useCurvedEnd")] public bool useCurvedEnd;
		[Serialize("useDrawDebug")] public bool useDrawDebug;
		[Serialize("name"        )] public StringID name;
		[Serialize("useCurvedEnd")] public int useCurvedEnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(useCurvedEnd));
				SerializeField(s, nameof(name));
			} else {
				SerializeField(s, nameof(useCurvedEnd));
				SerializeField(s, nameof(useDrawDebug));
				SerializeField(s, nameof(name));
			}
		}
		public override uint? ClassCRC => 0x040C7328;
	}
}

