namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class HitPhantomDetectorComponent : PhantomDetectorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC26BC3E0;
	}
}

