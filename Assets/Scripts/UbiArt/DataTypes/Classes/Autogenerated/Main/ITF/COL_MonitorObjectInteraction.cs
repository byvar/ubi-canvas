namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MonitorObjectInteraction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD538B259;
	}
}

