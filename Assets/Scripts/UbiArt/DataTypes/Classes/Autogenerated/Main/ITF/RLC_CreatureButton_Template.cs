namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_CreatureButton_Template : RLC_BasicButton_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFEE66DF2;
	}
}

