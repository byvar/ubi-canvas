using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class AnimFXEvent : AnimMarkerEvent {
		[Serialize("Action"  )] public FX_St Action;
		[Serialize("name"    )] public StringID name;
		[Serialize("posLocal")] public Vector2 posLocal;
		[Serialize("sender"  )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.VH) {
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(posLocal));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(posLocal));
			} else {
				SerializeField(s, nameof(Action));
			}
		}
		public enum FX_St {
			[Serialize("FX_Stop" )] op = 0,
			[Serialize("FX_Start")] art = 1,
		}
		public override uint? ClassCRC => 0xDFBC62A3;
	}
}

