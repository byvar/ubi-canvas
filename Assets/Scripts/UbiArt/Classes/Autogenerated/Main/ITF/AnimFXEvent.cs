using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class AnimFXEvent : AnimMarkerEvent {
		public FX Action;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RA) {
				Action = s.Serialize<FX>(Action, name: "Action");
			}
		}
		public enum FX {
			[Serialize("FX_Stop" )] Stop = 0,
			[Serialize("FX_Start")] Start = 1,
		}
		public override uint? ClassCRC => 0xDFBC62A3;
	}
}

