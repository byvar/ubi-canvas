namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_InteractiveDisplayEvent : Event {
		public bool bool__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
		}
		public override uint? ClassCRC => 0x889FF43A;
	}
}

