namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_FireFlyKrillSpawnerComponent_Template : CSerializable {
		public Path krillActorPath;
		public float detectionRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			krillActorPath = s.SerializeObject<Path>(krillActorPath, name: "krillActorPath");
			detectionRadius = s.Serialize<float>(detectionRadius, name: "detectionRadius");
		}
		public override uint? ClassCRC => 0xB9AD0DA6;
	}
}

