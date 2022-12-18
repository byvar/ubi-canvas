namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_WaveSpikyBallComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x64337A56;
	}
}

