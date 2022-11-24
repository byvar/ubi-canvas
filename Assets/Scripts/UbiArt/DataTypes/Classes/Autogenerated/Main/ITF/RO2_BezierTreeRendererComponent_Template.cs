namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_BezierTreeRendererComponent_Template : GraphicComponent_Template {
		public BezierCurveRenderer_Template bezierRenderer;
		public uint tileSpriteIndex = 0;
		public float tileSpriteSubDiv = 1f;
		public uint startSpriteIndex = 1;
		public float startSpriteLength = 1f;
		public uint endSpriteIndex = 2;
		public float endSpriteLength = 1f;
		public float spriteCyclePlayRate = 1f;
		public bool uvStretch = true;
		public bool uvAttachToHead = true;
		public bool uvScaleAdaptive;
		public float uvScrollSpeed;
		public float zOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bezierRenderer = s.SerializeObject<BezierCurveRenderer_Template>(bezierRenderer, name: "bezierRenderer");
			tileSpriteIndex = s.Serialize<uint>(tileSpriteIndex, name: "tileSpriteIndex");
			tileSpriteSubDiv = s.Serialize<float>(tileSpriteSubDiv, name: "tileSpriteSubDiv");
			startSpriteIndex = s.Serialize<uint>(startSpriteIndex, name: "startSpriteIndex");
			startSpriteLength = s.Serialize<float>(startSpriteLength, name: "startSpriteLength");
			endSpriteIndex = s.Serialize<uint>(endSpriteIndex, name: "endSpriteIndex");
			endSpriteLength = s.Serialize<float>(endSpriteLength, name: "endSpriteLength");
			spriteCyclePlayRate = s.Serialize<float>(spriteCyclePlayRate, name: "spriteCyclePlayRate");
			uvStretch = s.Serialize<bool>(uvStretch, name: "uvStretch");
			uvAttachToHead = s.Serialize<bool>(uvAttachToHead, name: "uvAttachToHead");
			uvScaleAdaptive = s.Serialize<bool>(uvScaleAdaptive, name: "uvScaleAdaptive");
			uvScrollSpeed = s.Serialize<float>(uvScrollSpeed, name: "uvScrollSpeed");
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
		}
		public override uint? ClassCRC => 0x174A6BDD;
	}
}

