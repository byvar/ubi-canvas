namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class TweenTranslationCircle : TweenTranslation {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xABA19E1E;
	}
}

