using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.RAVersion)]
	public partial class BaseCameraComponent : ActorComponent {
		public int remote;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				remote = s.Serialize<int>(remote, name: "remote");
			} else {
			}
		}
		public override uint? ClassCRC => 0x71405453;
	}
}

