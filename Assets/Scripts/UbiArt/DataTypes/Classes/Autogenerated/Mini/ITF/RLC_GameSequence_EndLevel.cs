namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_GameSequence_EndLevel : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDA009D33;
	}
}

