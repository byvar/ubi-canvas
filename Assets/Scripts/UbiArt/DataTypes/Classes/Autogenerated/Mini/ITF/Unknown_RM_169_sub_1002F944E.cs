namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RO2_EventChildLaunch : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x81BBDFEF;
	}
}

