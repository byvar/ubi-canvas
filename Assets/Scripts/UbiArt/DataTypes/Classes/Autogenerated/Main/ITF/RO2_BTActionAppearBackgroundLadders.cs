namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionAppearBackgroundLadders : RO2_BTActionAppearBackground {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8F1B7CC9;
	}
}

