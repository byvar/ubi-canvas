using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_FluidFallAIComponent_Template : GraphicComponent_Template {
		[Serialize("texture"                )] public Path texture;
		[Serialize("tileLength"             )] public float tileLength;
		[Serialize("tessellationLength"     )] public float tessellationLength;
		[Serialize("stimBezierLength"       )] public float stimBezierLength;
		[Serialize("stimBezierWidthFactor"  )] public float stimBezierWidthFactor;
		[Serialize("alphaLength"            )] public float alphaLength;
		[Serialize("useStim"                )] public int useStim;
		[Serialize("faction"                )] public uint faction;
		[Serialize("useAnnunciatorFx"       )] public int useAnnunciatorFx;
		[Serialize("durationAnnunciationFx" )] public float durationAnnunciationFx;
		[Serialize("modTileTexture"         )] public uint modTileTexture;
		[Serialize("fxNameAnnunciator"      )] public StringID fxNameAnnunciator;
		[Serialize("fxNameStartFFP"         )] public StringID fxNameStartFFP;
		[Serialize("fxNameEndFFP"           )] public StringID fxNameEndFFP;
		[Serialize("soundNameStartFFP"      )] public StringID soundNameStartFFP;
		[Serialize("soundNameAnnunciatorFFP")] public StringID soundNameAnnunciatorFFP;
		[Serialize("usePolyline"            )] public int usePolyline;
		[Serialize("polylineLength"         )] public float polylineLength;
		[Serialize("gameMaterial"           )] public Path gameMaterial;
		[Serialize("zOffset"                )] public float zOffset;
		[Serialize("ignoreEventTrigger"     )] public int ignoreEventTrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(texture));
			SerializeField(s, nameof(tileLength));
			SerializeField(s, nameof(tessellationLength));
			SerializeField(s, nameof(stimBezierLength));
			SerializeField(s, nameof(stimBezierWidthFactor));
			SerializeField(s, nameof(alphaLength));
			SerializeField(s, nameof(useStim));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(useAnnunciatorFx));
			SerializeField(s, nameof(durationAnnunciationFx));
			SerializeField(s, nameof(modTileTexture));
			SerializeField(s, nameof(fxNameAnnunciator));
			SerializeField(s, nameof(fxNameStartFFP));
			SerializeField(s, nameof(fxNameEndFFP));
			SerializeField(s, nameof(soundNameStartFFP));
			SerializeField(s, nameof(soundNameAnnunciatorFFP));
			SerializeField(s, nameof(usePolyline));
			SerializeField(s, nameof(polylineLength));
			SerializeField(s, nameof(gameMaterial));
			SerializeField(s, nameof(zOffset));
			SerializeField(s, nameof(ignoreEventTrigger));
		}
		public override uint? ClassCRC => 0x66F39045;
	}
}

