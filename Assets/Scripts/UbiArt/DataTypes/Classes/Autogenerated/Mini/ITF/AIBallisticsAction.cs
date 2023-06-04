namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIBallisticsAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE1F29BA5;
	}
}

