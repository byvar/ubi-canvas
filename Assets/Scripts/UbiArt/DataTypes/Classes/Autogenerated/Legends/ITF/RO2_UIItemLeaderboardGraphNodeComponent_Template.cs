namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIItemLeaderboardGraphNodeComponent_Template : UIItemBasic_Template {
		public float blinkScaleMin2;
		public float blinkScale2;
		public float blinkPeriod2;
		public float blinkMinBlendSpeed2;
		public float hightlightAlphaMin2;
		public float hightlightAlpha2;
		public float hightlightPeriod2;
		public float hightlightMinBlendSpeed2;
		public float margingIconX;
		public float activatingDuration2;
		public float nameOffset;
		public Color mainPlayerBackgroundColorFactor;
		public StringID actorIconSelected2;
		public Vec2d actorIconOffset2;
		public int inverseShadowState2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			blinkScaleMin2 = s.Serialize<float>(blinkScaleMin2, name: "blinkScaleMin");
			blinkScale2 = s.Serialize<float>(blinkScale2, name: "blinkScale");
			blinkPeriod2 = s.Serialize<float>(blinkPeriod2, name: "blinkPeriod");
			blinkMinBlendSpeed2 = s.Serialize<float>(blinkMinBlendSpeed2, name: "blinkMinBlendSpeed");
			hightlightAlphaMin2 = s.Serialize<float>(hightlightAlphaMin2, name: "hightlightAlphaMin");
			hightlightAlpha2 = s.Serialize<float>(hightlightAlpha2, name: "hightlightAlpha");
			hightlightPeriod2 = s.Serialize<float>(hightlightPeriod2, name: "hightlightPeriod");
			hightlightMinBlendSpeed2 = s.Serialize<float>(hightlightMinBlendSpeed2, name: "hightlightMinBlendSpeed");
			margingIconX = s.Serialize<float>(margingIconX, name: "margingIconX");
			activatingDuration2 = s.Serialize<float>(activatingDuration2, name: "activatingDuration");
			nameOffset = s.Serialize<float>(nameOffset, name: "nameOffset");
			mainPlayerBackgroundColorFactor = s.SerializeObject<Color>(mainPlayerBackgroundColorFactor, name: "mainPlayerBackgroundColorFactor");
			actorIconSelected2 = s.SerializeObject<StringID>(actorIconSelected2, name: "actorIconSelected");
			actorIconOffset2 = s.SerializeObject<Vec2d>(actorIconOffset2, name: "actorIconOffset");
			inverseShadowState2 = s.Serialize<int>(inverseShadowState2, name: "inverseShadowState");
		}
		public override uint? ClassCRC => 0x0D055EDD;
	}
}

