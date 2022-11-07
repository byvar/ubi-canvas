namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventGameplayScreenshot : Event {
		public float delay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			delay = s.Serialize<float>(delay, name: "delay");
		}
		public override uint? ClassCRC => 0xFBDEF2B8;
	}
}

