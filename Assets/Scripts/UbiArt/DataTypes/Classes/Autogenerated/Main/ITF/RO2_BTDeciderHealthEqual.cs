namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_BTDeciderHealthEqual : BTDecider {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1CB82C31;
	}
}

