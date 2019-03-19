using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class TriggerEventCountComponent_Template : ActorComponent_Template {
		[Serialize("eventToCount")] public Generic<Event> eventToCount;
		[Serialize("eventToSend" )] public Generic<Event> eventToSend;
		[Serialize("useGenerics" )] public bool useGenerics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(eventToCount));
				SerializeField(s, nameof(eventToSend));
				SerializeField(s, nameof(useGenerics), boolAsByte: true);
			} else {
				SerializeField(s, nameof(eventToCount));
				SerializeField(s, nameof(eventToSend));
			}
		}
		public override uint? ClassCRC => 0x609B3DB2;
	}
}

