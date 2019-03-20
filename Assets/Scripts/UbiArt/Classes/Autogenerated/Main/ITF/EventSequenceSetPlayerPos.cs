using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.VH | GameFlags.RO | GameFlags.COL)]
	public partial class EventSequenceSetPlayerPos : Event {
		[Serialize("actor"        )] public string actor;
		[Serialize("playerId"     )] public uint playerId;
		[Serialize("playerMode"   )] public uint playerMode;
		[Serialize("useBaseAdjust")] public bool useBaseAdjust;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actor));
			SerializeField(s, nameof(playerId));
			SerializeField(s, nameof(playerMode));
			SerializeField(s, nameof(useBaseAdjust));
		}
		public override uint? ClassCRC => 0xCB3E87E9;
	}
}

