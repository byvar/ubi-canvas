namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_DrcLifeElementComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x68DA00B7;
	}
}

