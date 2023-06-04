namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ToadPlugPlayableControllerInGameInfo : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x66A5A656;
	}
}

