namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_BubblePrizeBumperComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2053B040;
	}
}

