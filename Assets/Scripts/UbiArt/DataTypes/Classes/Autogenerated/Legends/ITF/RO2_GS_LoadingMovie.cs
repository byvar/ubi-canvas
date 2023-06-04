namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_GS_LoadingMovie : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD7EE15BB;
	}
}

