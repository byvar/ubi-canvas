namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class EventReceivePlayAnimComponent_Template : ActorComponent_Template {
		public Generic<PhysShape> phantomShape;
		public Generic<Event> watchEvent;
		public Generic<Event> resetStartValueEvent;
		public Vec2d phantomOffset;
		public float speedIncrease;
		public float decrease;
		public float maxSpeed;
		public float minSpeed;
		public float resetTimeMin;
		public float resetTimeMax;
		public float resetDelay;
		public bool lockOnEnd;
		public bool useSingleEvent;
		public float bounceFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			phantomShape = s.SerializeObject<Generic<PhysShape>>(phantomShape, name: "phantomShape");
			watchEvent = s.SerializeObject<Generic<Event>>(watchEvent, name: "watchEvent");
			resetStartValueEvent = s.SerializeObject<Generic<Event>>(resetStartValueEvent, name: "resetStartValueEvent");
			phantomOffset = s.SerializeObject<Vec2d>(phantomOffset, name: "phantomOffset");
			speedIncrease = s.Serialize<float>(speedIncrease, name: "speedIncrease");
			decrease = s.Serialize<float>(decrease, name: "decrease");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			minSpeed = s.Serialize<float>(minSpeed, name: "minSpeed");
			resetTimeMin = s.Serialize<float>(resetTimeMin, name: "resetTimeMin");
			resetTimeMax = s.Serialize<float>(resetTimeMax, name: "resetTimeMax");
			resetDelay = s.Serialize<float>(resetDelay, name: "resetDelay");
			lockOnEnd = s.Serialize<bool>(lockOnEnd, name: "lockOnEnd");
			useSingleEvent = s.Serialize<bool>(useSingleEvent, name: "useSingleEvent");
			bounceFactor = s.Serialize<float>(bounceFactor, name: "bounceFactor");
		}
		public override uint? ClassCRC => 0xAB971CA8;
	}
}

