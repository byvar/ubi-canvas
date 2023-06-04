namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_GS_CreatureTree : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDDE58BF1;
	}
}

