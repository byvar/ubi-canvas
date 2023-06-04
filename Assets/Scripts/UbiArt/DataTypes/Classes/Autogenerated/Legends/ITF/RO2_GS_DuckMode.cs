namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_GS_DuckMode : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF34C1E7B;
	}
}

