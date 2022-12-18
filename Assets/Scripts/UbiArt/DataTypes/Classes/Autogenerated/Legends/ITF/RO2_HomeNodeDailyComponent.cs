namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_HomeNodeDailyComponent : RO2_HomeNodeComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x499DDA1B;
	}
}

