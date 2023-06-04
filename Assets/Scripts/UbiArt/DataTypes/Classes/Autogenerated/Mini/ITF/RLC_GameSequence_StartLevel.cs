namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_GameSequence_StartLevel : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x372966BF;
	}
}

