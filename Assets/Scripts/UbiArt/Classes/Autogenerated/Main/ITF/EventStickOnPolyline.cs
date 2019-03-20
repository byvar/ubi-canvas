using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventStickOnPolyline : Event {
		[Serialize("sticked"    )] public bool sticked;
		[Serialize("speed"      )] public Vector2 speed;
		[Serialize("polylineRef")] public uint polylineRef;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sticked));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sticked));
				SerializeField(s, nameof(speed));
				SerializeField(s, nameof(polylineRef));
			} else {
				SerializeField(s, nameof(sticked));
				SerializeField(s, nameof(speed));
			}
		}
		public override uint? ClassCRC => 0x1C166A64;
	}
}

