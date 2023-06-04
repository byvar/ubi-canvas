namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ToadPS_FollowPlayer : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2F2AD604;
	}
}

