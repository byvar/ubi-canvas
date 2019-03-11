using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ScoreRecapRewardSpawnerComponent : ActorComponent {
		[Serialize("offset")] public Vector3 offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(offset));
			} else {
			}
		}
		public override uint? ClassCRC => 0x84722B13;
	}
}

