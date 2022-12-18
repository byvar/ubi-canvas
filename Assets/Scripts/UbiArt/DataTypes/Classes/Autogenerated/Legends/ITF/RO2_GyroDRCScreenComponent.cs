namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_GyroDRCScreenComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0E7D41D3;
	}
}

