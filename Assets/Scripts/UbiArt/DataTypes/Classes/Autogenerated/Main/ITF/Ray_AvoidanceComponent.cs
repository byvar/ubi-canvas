namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AvoidanceComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8E1B2C67;
	}
}

