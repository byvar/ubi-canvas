namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventGameAndWatchEventDepth : Event {
		public float float__0;
		public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
		}
		public override uint? ClassCRC => 0xC7610C2B;
	}
}

