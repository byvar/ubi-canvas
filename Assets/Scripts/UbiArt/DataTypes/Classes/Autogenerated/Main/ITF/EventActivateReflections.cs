namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventActivateReflections : Event {
		public bool RenderInReflections;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			RenderInReflections = s.Serialize<bool>(RenderInReflections, name: "RenderInReflections");
		}
		public override uint? ClassCRC => 0x95F380DD;
	}
}

