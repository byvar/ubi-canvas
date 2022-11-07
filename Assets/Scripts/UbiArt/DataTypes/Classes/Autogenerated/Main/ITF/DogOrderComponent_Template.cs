namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class DogOrderComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x73B10872;
	}
}

