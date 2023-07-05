namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BasculePlatformComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x95182E71;
	}
}
