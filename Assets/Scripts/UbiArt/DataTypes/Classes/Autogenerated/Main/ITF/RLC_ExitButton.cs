namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ExitButton : RLC_BasicAdventureButton {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1FC2140C;
	}
}

