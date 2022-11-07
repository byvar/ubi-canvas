namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_GameScreen_LevelStats : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA61A5952;
	}
}

