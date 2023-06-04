namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class WithAnimStateImplement : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3330381D;
	}
}

