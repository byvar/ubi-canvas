using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class StatData : CSerializable {
		[Serialize("allPlayers")] public bool allPlayers;
		[Serialize("playerId"  )] public uint playerId;
		[Serialize("stats"     )] public CMap<string, StatValue> stats;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(allPlayers));
			SerializeField(s, nameof(playerId));
			SerializeField(s, nameof(stats));
		}
	}
}

