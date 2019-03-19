using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class AnimMarkerTriggerComponent_Template : TriggerComponent_Template {
		[Serialize("markerEvents")] public CList<MarkerEvent> markerEvents;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(markerEvents));
			}
		}
		public override uint? ClassCRC => 0x5D8DDF58;
	}
}

