using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SeekingJellyfishAIComponent : ActorComponent {
		public bool autoStart;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					autoStart = s.Serialize<bool>(autoStart, name: "autoStart", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					autoStart = s.Serialize<bool>(autoStart, name: "autoStart");
				}
			}
		}
		public override uint? ClassCRC => 0xB7E47051;
	}
}

