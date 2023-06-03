namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_GS_Home : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x130996E6;
	}
}

