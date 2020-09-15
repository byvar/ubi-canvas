using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class EventEnableShadow : Event {
		public bool Enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.RA) {
				Enable = s.Serialize<bool>(Enable, name: "Enable");
			}
		}
		public override uint? ClassCRC => 0xF1CB5691;
	}
}

