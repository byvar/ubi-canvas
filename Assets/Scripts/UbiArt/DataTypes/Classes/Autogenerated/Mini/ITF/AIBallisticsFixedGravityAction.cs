namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIBallisticsFixedGravityAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5740C9B0;
	}
}

