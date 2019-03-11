using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_FriendlyBTAIComponent : Ray_AINetworkComponent {
		[Serialize("targetWaypoint")] public ObjectPath targetWaypoint;
		[Serialize("respawnPoint"  )] public ObjectPath respawnPoint;
		[Serialize("rescued"       )] public bool rescued;
		[Serialize("rescueFinished")] public bool rescueFinished;
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

