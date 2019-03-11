using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimFXEvent : AnimMarkerEvent {
		[Serialize("Action"  )] public FX_St Action;
		[Serialize("name"    )] public StringID name;
		[Serialize("posLocal")] public Vector2 posLocal;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
			} else if (Settings.s.game == Settings.Game.RL) {
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

