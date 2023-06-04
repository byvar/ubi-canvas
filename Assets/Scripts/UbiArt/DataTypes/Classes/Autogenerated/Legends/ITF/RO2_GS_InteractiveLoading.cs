namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_GS_InteractiveLoading : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB2DD2019;
	}
}

