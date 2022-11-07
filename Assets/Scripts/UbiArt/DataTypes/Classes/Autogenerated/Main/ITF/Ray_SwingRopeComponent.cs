namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_SwingRopeComponent : SoftPlatformComponent {
		public Angle initialAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				initialAngle = s.SerializeObject<Angle>(initialAngle, name: "initialAngle");
			}
		}
		public override uint? ClassCRC => 0x6AA2E69F;
	}
}

