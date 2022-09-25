using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.RA)]
	public partial class BezierTreeRendererComponent_Template : GraphicComponent_Template {
		public BezierCurveRenderer_Template bezierRenderer;
		public uint tileSpriteIndex;
		public float tileSpriteSubDiv;
		public uint startSpriteIndex;
		public float startSpriteLength;
		public uint endSpriteIndex;
		public float endSpriteLength;
		public float spriteCyclePlayRate;
		public bool uvStretch;
		public bool uvAttachToHead;
		public bool uvScaleAdaptive;
		public float uvScrollSpeed;
		public float zOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL || s.Settings.game == Settings.Game.RL) {
				bezierRenderer = s.SerializeObject<BezierCurveRenderer_Template>(bezierRenderer, name: "bezierRenderer");
				tileSpriteIndex = s.Serialize<uint>(tileSpriteIndex, name: "tileSpriteIndex");
				tileSpriteSubDiv = s.Serialize<float>(tileSpriteSubDiv, name: "tileSpriteSubDiv");
				startSpriteIndex = s.Serialize<uint>(startSpriteIndex, name: "startSpriteIndex");
				startSpriteLength = s.Serialize<float>(startSpriteLength, name: "startSpriteLength");
				endSpriteIndex = s.Serialize<uint>(endSpriteIndex, name: "endSpriteIndex");
				endSpriteLength = s.Serialize<float>(endSpriteLength, name: "endSpriteLength");
				spriteCyclePlayRate = s.Serialize<float>(spriteCyclePlayRate, name: "spriteCyclePlayRate");
				uvStretch = s.Serialize<bool>(uvStretch, name: "uvStretch", options: CSerializerObject.Options.BoolAsByte);
				uvAttachToHead = s.Serialize<bool>(uvAttachToHead, name: "uvAttachToHead", options: CSerializerObject.Options.BoolAsByte);
				uvScaleAdaptive = s.Serialize<bool>(uvScaleAdaptive, name: "uvScaleAdaptive", options: CSerializerObject.Options.BoolAsByte);
				uvScrollSpeed = s.Serialize<float>(uvScrollSpeed, name: "uvScrollSpeed");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			} else {
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
		}
		public override uint? ClassCRC => 0x604D285E;
	}
}

