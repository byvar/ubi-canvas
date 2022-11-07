namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class SubSceneComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1778A9FF;
	}
}

