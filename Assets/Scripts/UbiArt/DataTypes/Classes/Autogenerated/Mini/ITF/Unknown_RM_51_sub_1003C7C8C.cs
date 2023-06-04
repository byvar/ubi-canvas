namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIBumperAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBD1CC89F;
	}
}

