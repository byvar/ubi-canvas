using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_FriendlyBTAIComponent : Ray_AINetworkComponent {
		[Serialize("targetWaypoint")] public ObjectPath targetWaypoint;
		[Serialize("respawnPoint"  )] public ObjectPath respawnPoint;
		[Serialize("rescued"       )] public int rescued;
		[Serialize("rescueFinished")] public int rescueFinished;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(targetWaypoint));
				SerializeField(s, nameof(respawnPoint));
				SerializeField(s, nameof(rescued));
				SerializeField(s, nameof(rescueFinished));
			}
		}
		public override uint? ClassCRC => 0x35699FA6;
	}
}

