using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class KeepAliveComponent_Template : ActorComponent_Template {
		public bool startDying;
		public bool useFade;
		public float fadeDuration;
		public int startDying2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				startDying2 = s.Serialize<int>(startDying2, name: "startDying");
			} else {
				startDying = s.Serialize<bool>(startDying, name: "startDying");
				useFade = s.Serialize<bool>(useFade, name: "useFade");
				fadeDuration = s.Serialize<float>(fadeDuration, name: "fadeDuration");
			}
		}
		public override uint? ClassCRC => 0x991810D0;
	}
}

