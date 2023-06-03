namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_GS_Runner : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEA845760;
	}
}

