using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class EventEnableShadow : Event {
		[Serialize("Enable")] public bool Enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.RA) {
				SerializeField(s, nameof(Enable));
			}
		}
		public override uint? ClassCRC => 0xF1CB5691;
	}
}

