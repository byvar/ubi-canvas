namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_BTShooterActionReceiveHit : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEB8C8864;
	}
}

