namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class VideoResourceStreamedBase : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEB52ECD5;
	}
}

