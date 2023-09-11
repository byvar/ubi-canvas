namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_SnakeDRCAIComponent : RO2_AIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x46C4A26B;
	}
}

