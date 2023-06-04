namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIFallNoPhysAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x42C6C844;
	}
}

