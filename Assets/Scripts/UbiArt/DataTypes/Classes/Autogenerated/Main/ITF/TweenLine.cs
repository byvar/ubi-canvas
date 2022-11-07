namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TweenLine : TweenTranslation {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC32163AC;
	}
}

