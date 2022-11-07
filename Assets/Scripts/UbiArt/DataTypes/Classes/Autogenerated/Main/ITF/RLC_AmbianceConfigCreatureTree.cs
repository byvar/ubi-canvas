namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AmbianceConfigCreatureTree : RLC_AmbianceConfig {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD6771431;
	}
}

