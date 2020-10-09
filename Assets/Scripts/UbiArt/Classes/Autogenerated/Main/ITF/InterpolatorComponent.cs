using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class InterpolatorComponent : ActorComponent {
		public StringID input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
			} else {
				input = s.SerializeObject<StringID>(input, name: "input");
			}
		}
		public override uint? ClassCRC => 0x5AF6429A;
	}
}

