namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RO2_SwarmRepellerPowerUp : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFEC73FB9;
	}
}

