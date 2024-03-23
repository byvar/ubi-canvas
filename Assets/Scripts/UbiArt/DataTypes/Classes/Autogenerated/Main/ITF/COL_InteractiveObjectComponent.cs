namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InteractiveObjectComponent : COL_BaseInteractiveComponentNew {
		[Description("Default state of the object, is none is saved")]
		public StringID defaultObjectState;
		[Description("Object states")]
		public CListO<COL_InteractiveObjectComponent.State> objectStates;
		[Description("Current state of the object when saved")]
		public StringID savedObjectState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				defaultObjectState = s.SerializeObject<StringID>(defaultObjectState, name: "defaultObjectState");
				objectStates = s.SerializeObject<CListO<COL_InteractiveObjectComponent.State>>(objectStates, name: "objectStates");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				savedObjectState = s.SerializeObject<StringID>(savedObjectState, name: "savedObjectState");
			}
		}
		public override uint? ClassCRC => 0x1EA037A7;

		public class State : CSerializable {
			[Description("State name")]
			public StringID name;
			[Description("check to save state")]
			public bool saveState;
			[Description("check to save state (don't reset if new game plus)")]
			public bool saveStatePersistentForNewGamePlus;

			[Description("Event sent when we enter the state")]
			public EventSender onStartEvent;
			[Description("Event sent when we exit the state")]
			public EventSender onStopEvent;
			[Description("Animation played when we enter the state")]
			public StringID onEnterAnim;
			public Enum_clientAnimInputValue clientAnimInputValue;

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.HasFlags(SerializeFlags.Default)) {
					name = s.SerializeObject<StringID>(name, name: "name");
					saveState = s.Serialize<bool>(saveState, name: "saveState", options: CSerializerObject.Options.BoolAsByte);
					saveStatePersistentForNewGamePlus = s.Serialize<bool>(saveStatePersistentForNewGamePlus, name: "saveStatePersistentForNewGamePlus", options: CSerializerObject.Options.BoolAsByte);

					onStartEvent = s.SerializeObject<EventSender>(onStartEvent, name: "onStartEvent");
					onStopEvent = s.SerializeObject<EventSender>(onStopEvent, name: "onStopEvent");
					onEnterAnim = s.SerializeObject<StringID>(onEnterAnim, name: "onEnterAnim");
					clientAnimInputValue = s.Serialize<Enum_clientAnimInputValue>(clientAnimInputValue, name: "clientAnimInputValue");

				}
			}
			public enum Enum_clientAnimInputValue {
				[Serialize("Value_0")] Value_0 = 0,
				[Serialize("Value_1")] Value_1 = 1,
				[Serialize("Value_2")] Value_2 = 2,
			}
		}
	}
}

