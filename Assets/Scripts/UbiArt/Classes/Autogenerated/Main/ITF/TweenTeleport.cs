using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenTeleport : TweenInstruction {
		[Serialize("name")] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(name));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(name));
			} else {
			}
		}
		public override uint? ClassCRC => 0x0E51C181;
	}
}

