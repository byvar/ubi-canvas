using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_OnEventSpawnLumsComponent_Template : ActorComponent_Template {
		[Serialize("listenEvents")] public CList<Generic<Event>> listenEvents;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(listenEvents));
		}
		public override uint? ClassCRC => 0x0961F62F;
	}
}

