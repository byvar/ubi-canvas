namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BaseInteraction : CSerializable {
		public StringID name;
		public Enum_triggeringType triggeringType;
		public Enum_triggeringClientType triggeringClientType;
		public StringID inputAction;
		public StringID interactingInputAction;
		public EventSender onStartEvent;
		public EventSender onEndEvent;
		[Description("Anim to play on the owner when the interaction starts")]
		public StringID onStartOwnerAnim;
		[Description("Anim to play on the client when the interaction starts")]
		public StringID onStartClientAnim;
		[Description("Tween to play on the owner when the interaction starts")]
		public StringID onStartOwnerTweenSet;
		[Description("Feedback to play on the owner when the interaction starts")]
		public StringID onStartOwnerFX;
		[Description("Feedback to play on the owner when the interaction ends")]
		public StringID onEndOwnerFX;
		public COL_BaseInteraction.ClientPlacement clientPlacement;
		public bool isButtonDisplayRequired;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				name = s.SerializeObject<StringID>(name, name: "name");
				triggeringType = s.Serialize<Enum_triggeringType>(triggeringType, name: "triggeringType");
				triggeringClientType = s.Serialize<Enum_triggeringClientType>(triggeringClientType, name: "triggeringClientType");
				inputAction = s.SerializeObject<StringID>(inputAction, name: "inputAction");
				interactingInputAction = s.SerializeObject<StringID>(interactingInputAction, name: "interactingInputAction");
				onStartEvent = s.SerializeObject<EventSender>(onStartEvent, name: "onStartEvent");
				onEndEvent = s.SerializeObject<EventSender>(onEndEvent, name: "onEndEvent");
				onStartOwnerAnim = s.SerializeObject<StringID>(onStartOwnerAnim, name: "onStartOwnerAnim");
				onStartClientAnim = s.SerializeObject<StringID>(onStartClientAnim, name: "onStartClientAnim");
				onStartOwnerTweenSet = s.SerializeObject<StringID>(onStartOwnerTweenSet, name: "onStartOwnerTweenSet");
				onStartOwnerFX = s.SerializeObject<StringID>(onStartOwnerFX, name: "onStartOwnerFX");
				onEndOwnerFX = s.SerializeObject<StringID>(onEndOwnerFX, name: "onEndOwnerFX");
				clientPlacement = s.SerializeObject<COL_BaseInteraction.ClientPlacement>(clientPlacement, name: "clientPlacement");
				isButtonDisplayRequired = s.Serialize<bool>(isButtonDisplayRequired, name: "isButtonDisplayRequired", options: CSerializerObject.Options.BoolAsByte);
			}
		}
		public override uint? ClassCRC => 0xC8F54CAD;

		public enum Enum_triggeringType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_triggeringClientType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}

		public class ClientPlacement : CSerializable {
			public StringID anim;
			public Enum_position position;
			public float displacementDuration;
			public Vec2d positionOffset;
			public Enum_facing facing;
			public CListP<int> authorizedPCStates;

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.HasFlags(SerializeFlags.Default)) {
					anim = s.SerializeObject<StringID>(anim, name: "anim");
					position = s.Serialize<Enum_position>(position, name: "position");
					displacementDuration = s.Serialize<float>(displacementDuration, name: "displacementDuration");
					positionOffset = s.SerializeObject<Vec2d>(positionOffset, name: "positionOffset");
					facing = s.Serialize<Enum_facing>(facing, name: "facing");
					authorizedPCStates = s.SerializeObject<CListP<int>>(authorizedPCStates, name: "authorizedPCStates");
				}
			}
			public enum Enum_position {
				[Serialize("Value_0")] Value_0 = 0,
				[Serialize("Value_1")] Value_1 = 1,
				[Serialize("Value_2")] Value_2 = 2,
			}
			public enum Enum_facing {
				[Serialize("Value_0")] Value_0 = 0,
				[Serialize("Value_1")] Value_1 = 1,
				[Serialize("Value_2")] Value_2 = 2,
			}
		}
	}
}

