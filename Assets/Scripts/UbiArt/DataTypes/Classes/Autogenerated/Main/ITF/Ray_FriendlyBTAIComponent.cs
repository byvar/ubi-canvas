namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_FriendlyBTAIComponent : Ray_AINetworkComponent {
		public ObjectPath targetWaypoint;
		public ObjectPath respawnPoint;
		public int rescued;
		public int rescueFinished;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				targetWaypoint = s.SerializeObject<ObjectPath>(targetWaypoint, name: "targetWaypoint");
				respawnPoint = s.SerializeObject<ObjectPath>(respawnPoint, name: "respawnPoint");
				rescued = s.Serialize<int>(rescued, name: "rescued");
				rescueFinished = s.Serialize<int>(rescueFinished, name: "rescueFinished");
			}
		}
		public override uint? ClassCRC => 0x35699FA6;
	}
}

