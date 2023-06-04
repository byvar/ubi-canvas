namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIFallAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x24E0E50F;
	}
}

