using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BezierTreeRendererComponent_Template : GraphicComponent_Template {
		[Serialize("bezierRenderer"     )] public BezierCurveRenderer_Template bezierRenderer;
		[Serialize("tileSpriteIndex"    )] public uint tileSpriteIndex;
		[Serialize("tileSpriteSubDiv"   )] public float tileSpriteSubDiv;
		[Serialize("startSpriteIndex"   )] public uint startSpriteIndex;
		[Serialize("startSpriteLength"  )] public float startSpriteLength;
		[Serialize("endSpriteIndex"     )] public uint endSpriteIndex;
		[Serialize("endSpriteLength"    )] public float endSpriteLength;
		[Serialize("spriteCyclePlayRate")] public float spriteCyclePlayRate;
		[Serialize("uvStretch"          )] public bool uvStretch;
		[Serialize("uvAttachToHead"     )] public bool uvAttachToHead;
		[Serialize("uvScaleAdaptive"    )] public bool uvScaleAdaptive;
		[Serialize("uvScrollSpeed"      )] public float uvScrollSpeed;
		[Serialize("zOffset"            )] public float zOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bezierRenderer));
			SerializeField(s, nameof(tileSpriteIndex));
			SerializeField(s, nameof(tileSpriteSubDiv));
			SerializeField(s, nameof(startSpriteIndex));
			SerializeField(s, nameof(startSpriteLength));
			SerializeField(s, nameof(endSpriteIndex));
			SerializeField(s, nameof(endSpriteLength));
			SerializeField(s, nameof(spriteCyclePlayRate));
			SerializeField(s, nameof(uvStretch));
			SerializeField(s, nameof(uvAttachToHead));
			SerializeField(s, nameof(uvScaleAdaptive));
			SerializeField(s, nameof(uvScrollSpeed));
			SerializeField(s, nameof(zOffset));
		}
		public override uint? ClassCRC => 0x174A6BDD;
	}
}

