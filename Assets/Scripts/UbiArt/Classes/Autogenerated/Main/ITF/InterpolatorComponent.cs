using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class InterpolatorComponent : ActorComponent {
		[Serialize("input")] public StringID input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
			} else {
				SerializeField(s, nameof(input));
			}
		}
		public override uint? ClassCRC => 0x5AF6429A;
	}
}

