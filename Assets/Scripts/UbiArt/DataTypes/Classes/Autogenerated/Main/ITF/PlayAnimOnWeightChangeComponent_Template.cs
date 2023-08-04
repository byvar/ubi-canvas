namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class PlayAnimOnWeightChangeComponent_Template : ActorComponent_Template {
		public StringID enterAnim;
		public StringID enterAnimIdle;
		public StringID exitAnim;
		public StringID exitAnimIdle;
		public bool listenToTrigger = true;
		public bool listenToWeight = true;
		public Generic<Event> listenToEvent;
		public bool stayOnEnter;
		public float weightThreshold;
		public Generic<Event> onEnterEvent;
		public Generic<Event> onExitEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enterAnim = s.SerializeObject<StringID>(enterAnim, name: "enterAnim");
			enterAnimIdle = s.SerializeObject<StringID>(enterAnimIdle, name: "enterAnimIdle");
			exitAnim = s.SerializeObject<StringID>(exitAnim, name: "exitAnim");
			exitAnimIdle = s.SerializeObject<StringID>(exitAnimIdle, name: "exitAnimIdle");
			listenToTrigger = s.Serialize<bool>(listenToTrigger, name: "listenToTrigger");
			listenToWeight = s.Serialize<bool>(listenToWeight, name: "listenToWeight");
			listenToEvent = s.SerializeObject<Generic<Event>>(listenToEvent, name: "listenToEvent");
			stayOnEnter = s.Serialize<bool>(stayOnEnter, name: "stayOnEnter");
			weightThreshold = s.Serialize<float>(weightThreshold, name: "weightThreshold");
			onEnterEvent = s.SerializeObject<Generic<Event>>(onEnterEvent, name: "onEnterEvent");
			onExitEvent = s.SerializeObject<Generic<Event>>(onExitEvent, name: "onExitEvent");
		}
		public override uint? ClassCRC => 0x47C0AF3E;
	}
}

