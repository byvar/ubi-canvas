namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIItemLeaderboardGraphNodeComponent_Template : CSerializable {
		public float blinkScaleMin;
		public float blinkScale;
		public float blinkPeriod;
		public float blinkMinBlendSpeed;
		public float hightlightAlphaMin;
		public float hightlightAlpha;
		public float hightlightPeriod;
		public float hightlightMinBlendSpeed;
		public float margingIconX;
		public float activatingDuration;
		public float nameOffset;
		public Color mainPlayerBackgroundColorFactor;
		public StringID actorIconSelected;
		public Vec2d actorIconOffset;
		public int inverseShadowState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			blinkScaleMin = s.Serialize<float>(blinkScaleMin, name: "blinkScaleMin");
			blinkScale = s.Serialize<float>(blinkScale, name: "blinkScale");
			blinkPeriod = s.Serialize<float>(blinkPeriod, name: "blinkPeriod");
			blinkMinBlendSpeed = s.Serialize<float>(blinkMinBlendSpeed, name: "blinkMinBlendSpeed");
			hightlightAlphaMin = s.Serialize<float>(hightlightAlphaMin, name: "hightlightAlphaMin");
			hightlightAlpha = s.Serialize<float>(hightlightAlpha, name: "hightlightAlpha");
			hightlightPeriod = s.Serialize<float>(hightlightPeriod, name: "hightlightPeriod");
			hightlightMinBlendSpeed = s.Serialize<float>(hightlightMinBlendSpeed, name: "hightlightMinBlendSpeed");
			margingIconX = s.Serialize<float>(margingIconX, name: "margingIconX");
			activatingDuration = s.Serialize<float>(activatingDuration, name: "activatingDuration");
			nameOffset = s.Serialize<float>(nameOffset, name: "nameOffset");
			mainPlayerBackgroundColorFactor = s.SerializeObject<Color>(mainPlayerBackgroundColorFactor, name: "mainPlayerBackgroundColorFactor");
			actorIconSelected = s.SerializeObject<StringID>(actorIconSelected, name: "actorIconSelected");
			actorIconOffset = s.SerializeObject<Vec2d>(actorIconOffset, name: "actorIconOffset");
			inverseShadowState = s.Serialize<int>(inverseShadowState, name: "inverseShadowState");
		}
		public override uint? ClassCRC => 0x0D055EDD;
	}
}

