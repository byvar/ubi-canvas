namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class SequencePlayerControl_evt : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x11D40AAF;
	}
}

