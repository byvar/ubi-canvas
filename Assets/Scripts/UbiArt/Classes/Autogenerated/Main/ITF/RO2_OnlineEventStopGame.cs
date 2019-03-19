using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_OnlineEventStopGame : Event {
		[Serialize("gameType")] public char gameType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(gameType));
		}
		public override uint? ClassCRC => 0x23078B67;
	}
}

