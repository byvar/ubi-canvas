namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class StateDeath : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x22B60266;
	}
}

