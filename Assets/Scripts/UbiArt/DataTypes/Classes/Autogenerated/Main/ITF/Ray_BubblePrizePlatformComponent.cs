namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_BubblePrizePlatformComponent : Ray_ChildLaunchComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x60480499;
	}
}

