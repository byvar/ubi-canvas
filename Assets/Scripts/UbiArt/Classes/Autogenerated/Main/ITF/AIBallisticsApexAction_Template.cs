using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class AIBallisticsApexAction_Template : AIBallisticsAction_Template {
		[Serialize("duration")] public float duration;
		[Serialize("speed"   )] public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(speed));
			} else {
			}
		}
		public override uint? ClassCRC => 0x24AE934A;
	}
}

