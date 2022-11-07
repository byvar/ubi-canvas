namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventViewportVisibility : Event {
		public uint ViewportVisibility;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ViewportVisibility = s.Serialize<uint>(ViewportVisibility, name: "ViewportVisibility");
		}
		public override uint? ClassCRC => 0x6CBBD40F;
	}
}

