namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GameProgressEvent : Event {
		public StringID Name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Name = s.SerializeObject<StringID>(Name, name: "Name");
		}
		public override uint? ClassCRC => 0x698778B8;
	}
}

