using UnityEngine;

namespace UbiArt.ITF {
	public partial class InterpolatorComponent : ActorComponent {
		[Serialize("input")] public StringID input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(input));
			}
		}
		public override uint? ClassCRC => 0x5AF6429A;
	}
}

