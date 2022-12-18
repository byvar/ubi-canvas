namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_DRCHeartComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7C4B9429;
	}
}

