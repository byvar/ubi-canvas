namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_DRCEventManagerComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4A1E4290;
	}
}

