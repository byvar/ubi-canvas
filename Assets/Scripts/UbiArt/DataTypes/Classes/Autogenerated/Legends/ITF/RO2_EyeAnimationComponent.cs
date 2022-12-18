namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_EyeAnimationComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2405D2D2;
	}
}

