namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_GroundEnemyAIComponent : Ray_AIComponent {
		public int useRaycast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useRaycast = s.Serialize<int>(useRaycast, name: "useRaycast");
		}
		public override uint? ClassCRC => 0xDA325BB4;
	}
}

