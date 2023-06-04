namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_GS_AdversarialSoccer : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA4F3CAA0;
	}
}

