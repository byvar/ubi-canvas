namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_GameManager : GameManager {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3664F4EC;
	}
}

