using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL | GameFlags.RL)]
	public partial class BezierTreeRendererComponent_Template : GraphicComponent_Template {
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
			if (Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(bezierRenderer));
				SerializeField(s, nameof(tileSpriteIndex));
				SerializeField(s, nameof(tileSpriteSubDiv));
				SerializeField(s, nameof(startSpriteIndex));
				SerializeField(s, nameof(startSpriteLength));
				SerializeField(s, nameof(endSpriteIndex));
				SerializeField(s, nameof(endSpriteLength));
				SerializeField(s, nameof(spriteCyclePlayRate));
				SerializeField(s, nameof(uvStretch), boolAsByte: true);
				SerializeField(s, nameof(uvAttachToHead), boolAsByte: true);
				SerializeField(s, nameof(uvScaleAdaptive), boolAsByte: true);
				SerializeField(s, nameof(uvScrollSpeed));
				SerializeField(s, nameof(zOffset));
			} else {
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
		}
		public override uint? ClassCRC => 0x604D285E;
	}
}

