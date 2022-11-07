namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TweenCircle : TweenTranslation {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2519E5B8;
	}
}

