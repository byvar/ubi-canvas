namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventAchievement : Event {
		public StringID StringID__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
		}
		public override uint? ClassCRC => 0xD8B0158C;
	}
}

