namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_GameScreen_Framework : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCB76E58A;
	}
}

