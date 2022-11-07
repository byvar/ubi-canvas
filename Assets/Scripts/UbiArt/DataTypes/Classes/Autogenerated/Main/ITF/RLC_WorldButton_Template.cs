namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_WorldButton_Template : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5AB27EC4;
	}
}

