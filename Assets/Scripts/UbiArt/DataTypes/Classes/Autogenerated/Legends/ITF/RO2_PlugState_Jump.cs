namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_PlugState_Jump : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD1485AC1;
	}
}

