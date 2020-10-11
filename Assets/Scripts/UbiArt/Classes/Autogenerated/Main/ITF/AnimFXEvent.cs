using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimFXEvent : AnimMarkerEvent {
		public FX Action;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RA || Settings.s.game == Settings.Game.RM) {
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

