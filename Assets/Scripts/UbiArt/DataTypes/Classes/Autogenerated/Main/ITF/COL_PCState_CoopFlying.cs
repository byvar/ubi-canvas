namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PCState_CoopFlying : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCA7C940E;
	}
}

