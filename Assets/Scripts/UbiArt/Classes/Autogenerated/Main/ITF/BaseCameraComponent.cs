using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.RAVersion)]
	public partial class BaseCameraComponent : ActorComponent {
		public int remote;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.VH) {
				remote = s.Serialize<int>(remote, name: "remote");
			} else {
			}
		}
		public override uint? ClassCRC => 0x71405453;
	}
}

