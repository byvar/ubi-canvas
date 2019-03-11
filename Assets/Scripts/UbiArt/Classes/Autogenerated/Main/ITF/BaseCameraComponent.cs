using UnityEngine;

namespace UbiArt.ITF {
	public partial class BaseCameraComponent : ActorComponent {
		[Serialize("remote")] public bool remote;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(remote));
			} else {
			}
		}
		public override uint? ClassCRC => 0x71405453;
	}
}

