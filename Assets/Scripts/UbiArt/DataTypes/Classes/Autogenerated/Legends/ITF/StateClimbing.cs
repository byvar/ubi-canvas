namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RM)]
	public partial class StateClimbing : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xAA76AAB3;
	}
}

