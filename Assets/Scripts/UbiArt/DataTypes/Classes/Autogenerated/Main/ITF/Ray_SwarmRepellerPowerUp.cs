namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_SwarmRepellerPowerUp : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x01A51BC1;
	}
}

