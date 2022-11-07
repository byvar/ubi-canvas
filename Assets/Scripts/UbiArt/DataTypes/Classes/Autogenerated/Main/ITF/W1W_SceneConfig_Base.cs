namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_SceneConfig_Base : SceneConfig {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1BCD8861;
	}
}

