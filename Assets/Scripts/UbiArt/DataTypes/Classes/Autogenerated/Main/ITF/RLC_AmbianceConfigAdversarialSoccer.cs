namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AmbianceConfigAdversarialSoccer : RLC_AmbianceConfig {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x48668C0D;
	}
}

