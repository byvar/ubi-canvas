namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class GameScreen : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD491DDAE;
	}
}

