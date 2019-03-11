using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SequenceSwitchComponent_Template : ActorComponent_Template {
		[Serialize("reverse")] public bool reverse;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(reverse));
			} else {
			}
		}
		public override uint? ClassCRC => 0x2EC686A8;
	}
}

