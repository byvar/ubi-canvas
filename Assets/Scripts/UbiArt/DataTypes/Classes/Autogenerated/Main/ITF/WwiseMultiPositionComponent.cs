namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class WwiseMultiPositionComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2826687C;
	}
}

