using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSequenceSetPlayerPos : Event {
		[Serialize("playerId"     )] public uint playerId;
		[Serialize("playerMode"   )] public uint playerMode;
		[Serialize("useBaseAdjust")] public bool useBaseAdjust;
		[Serialize("sender"       )] public uint sender;
		[Serialize("actor"        )] public string actor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(actor));
				SerializeField(s, nameof(playerId));
				SerializeField(s, nameof(playerMode));
				SerializeField(s, nameof(useBaseAdjust));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(actor));
				SerializeField(s, nameof(playerId));
				SerializeField(s, nameof(playerMode));
				SerializeField(s, nameof(useBaseAdjust));
			} else {
				SerializeField(s, nameof(playerId));
				SerializeField(s, nameof(playerMode));
				SerializeField(s, nameof(useBaseAdjust));
			}
		}
		public override uint? ClassCRC => 0xCB3E87E9;
	}
}

