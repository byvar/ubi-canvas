namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RO2_AILightningAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x92E8FCA3;
	}
}

