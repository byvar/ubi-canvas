namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventGotoRequest : Event {
		public Enum_gotoRequestType gotoRequestType;
		public Placeholder gotoTargetObject;
		public Vec2d gotoTargetPosition;
		public float gotoDuration;
		public bool run;
		public bool startOnGround;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			gotoRequestType = s.Serialize<Enum_gotoRequestType>(gotoRequestType, name: "gotoRequestType");
			gotoTargetObject = s.SerializeObject<Placeholder>(gotoTargetObject, name: "gotoTargetObject");
			gotoTargetPosition = s.SerializeObject<Vec2d>(gotoTargetPosition, name: "gotoTargetPosition");
			gotoDuration = s.Serialize<float>(gotoDuration, name: "gotoDuration");
			run = s.Serialize<bool>(run, name: "run", options: CSerializerObject.Options.BoolAsByte);
			startOnGround = s.Serialize<bool>(startOnGround, name: "startOnGround", options: CSerializerObject.Options.BoolAsByte);
		}
		public enum Enum_gotoRequestType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x9323E6CE;
	}
}

