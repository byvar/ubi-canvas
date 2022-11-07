namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ChangePageComponent : ActorComponent {
		public Vec2d finalDefaultPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				finalDefaultPos = s.SerializeObject<Vec2d>(finalDefaultPos, name: "finalDefaultPos");
			}
		}
		public override uint? ClassCRC => 0x4EC45669;
	}
}

