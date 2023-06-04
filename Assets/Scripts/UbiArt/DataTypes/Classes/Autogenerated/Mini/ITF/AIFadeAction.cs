namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIFadeAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2C76FFE1;
	}
}

