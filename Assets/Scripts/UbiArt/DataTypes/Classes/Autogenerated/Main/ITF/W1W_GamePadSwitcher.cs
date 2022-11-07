namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_GamePadSwitcher : ActorComponent {
		public StringID StringID__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
		}
		public override uint? ClassCRC => 0xA20E93EA;
	}
}

