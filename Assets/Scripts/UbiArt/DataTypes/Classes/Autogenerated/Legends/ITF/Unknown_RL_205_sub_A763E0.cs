namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ElCrapoPlugPlayableController : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xED74E62D;
	}
}

