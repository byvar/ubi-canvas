using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AILumsKingComponent : ActorComponent {
		[Serialize("useReveal")] public bool useReveal;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(useReveal));
			}
		}
		public override uint? ClassCRC => 0xC1778608;
	}
}

