namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_396_sub_B04180 : ActorComponent_Template {
		public SmartLocId smartLocID;
		public float displayDuration;
		public float transitionDuration;
		public uint nbRebound;
		public Vec2d startOffset;
		public float fastIncreaseTime;
		public float maxIncreaseTime;
		public float maxValueRef;
		public float minIncreaseTime;
		public float minValueRef;
		public StringID loopingSound;
		public StringID endSound;
		public CListO<Unknown_RL_44131_sub_B029B0> tagColorSettings;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			smartLocID = s.SerializeObject<SmartLocId>(smartLocID, name: "smartLocID");
			displayDuration = s.Serialize<float>(displayDuration, name: "displayDuration");
			transitionDuration = s.Serialize<float>(transitionDuration, name: "transitionDuration");
			nbRebound = s.Serialize<uint>(nbRebound, name: "nbRebound");
			startOffset = s.SerializeObject<Vec2d>(startOffset, name: "startOffset");
			fastIncreaseTime = s.Serialize<float>(fastIncreaseTime, name: "fastIncreaseTime");
			maxIncreaseTime = s.Serialize<float>(maxIncreaseTime, name: "maxIncreaseTime");
			maxValueRef = s.Serialize<float>(maxValueRef, name: "maxValueRef");
			minIncreaseTime = s.Serialize<float>(minIncreaseTime, name: "minIncreaseTime");
			minValueRef = s.Serialize<float>(minValueRef, name: "minValueRef");
			loopingSound = s.SerializeObject<StringID>(loopingSound, name: "loopingSound");
			endSound = s.SerializeObject<StringID>(endSound, name: "endSound");
			tagColorSettings = s.SerializeObject<CListO<Unknown_RL_44131_sub_B029B0>>(tagColorSettings, name: "tagColorSettings");
		}
		public override uint? ClassCRC => 0x4FDE15AC;

		[Games(GameFlags.RL)] // Only used as part of this class
		public partial class Unknown_RL_44131_sub_B029B0 : CSerializable {
			public StringID tag;
			public uint textStyle;
			public Color backgroundColor;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				tag = s.SerializeObject<StringID>(tag, name: "tag");
				textStyle = s.Serialize<uint>(textStyle, name: "textStyle");
				backgroundColor = s.SerializeObject<Color>(backgroundColor, name: "backgroundColor");
			}
		}
	}
}

