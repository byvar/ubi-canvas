namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_LizardPlugPlayableController : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE706030B;
	}
}

