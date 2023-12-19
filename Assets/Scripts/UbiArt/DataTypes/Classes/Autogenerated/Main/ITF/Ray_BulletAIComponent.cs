namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_BulletAIComponent : Ray_AIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8A12A76C;
	}
}

