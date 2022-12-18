namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class StateAttack_Template : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF5677685;
	}
}

