namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_SwingComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB746FB26;
	}
}

