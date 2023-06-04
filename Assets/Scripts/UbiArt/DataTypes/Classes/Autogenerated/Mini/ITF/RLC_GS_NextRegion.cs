namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_GS_NextRegion : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE26E9F3C;
	}
}

