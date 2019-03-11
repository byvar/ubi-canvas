using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlayAnimOnWeightChangeComponent : ActorComponent {
		[Serialize("isActive")] public bool isActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(isActive));
			} else {
			}
		}
		public override uint? ClassCRC => 0x8F988441;
	}
}

