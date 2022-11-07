namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventTimeFactor : Event {
		public EventFlip__eFlip ActorFactorValue;
		public EventFlip__eFlip WorldFactorValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ActorFactorValue = s.Serialize<EventFlip__eFlip>(ActorFactorValue, name: "ActorFactorValue");
			WorldFactorValue = s.Serialize<EventFlip__eFlip>(WorldFactorValue, name: "WorldFactorValue");
		}
		public enum EventFlip__eFlip {
			[Serialize("EventFlip::eFlip_Right"  )] Right = 0,
			[Serialize("EventFlip::eFlip_Left"   )] Left = 1,
			[Serialize("EventFlip::eFlip_Inverse")] Inverse = 2,
		}
		public override uint? ClassCRC => 0xD876F486;
	}
}

