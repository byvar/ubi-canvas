namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class StateVacuum_Template : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x30A7CF2C;
	}
}

