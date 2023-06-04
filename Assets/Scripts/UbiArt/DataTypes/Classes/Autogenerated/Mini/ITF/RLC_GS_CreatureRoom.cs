namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_GS_CreatureRoom : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x761CC3DF;
	}
}

