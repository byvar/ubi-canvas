using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.VH)]
	public partial class BaseCameraComponent : ActorComponent {
		[Serialize("remote")] public int remote;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(remote));
			} else {
			}
		}
		public override uint? ClassCRC => 0x71405453;
	}
}

