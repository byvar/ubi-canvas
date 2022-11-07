namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_FluidFallAIComponent_Template : GraphicComponent_Template {
		public Path texture;
		public float tileLength;
		public float tessellationLength;
		public float stimBezierLength;
		public float stimBezierWidthFactor;
		public float alphaLength;
		public int useStim;
		public uint faction;
		public int useAnnunciatorFx;
		public float durationAnnunciationFx;
		public uint modTileTexture;
		public StringID fxNameAnnunciator;
		public StringID fxNameStartFFP;
		public StringID fxNameEndFFP;
		public StringID soundNameStartFFP;
		public StringID soundNameAnnunciatorFFP;
		public int usePolyline;
		public float polylineLength;
		public Path gameMaterial;
		public float zOffset;
		public int ignoreEventTrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			texture = s.SerializeObject<Path>(texture, name: "texture");
			tileLength = s.Serialize<float>(tileLength, name: "tileLength");
			tessellationLength = s.Serialize<float>(tessellationLength, name: "tessellationLength");
			stimBezierLength = s.Serialize<float>(stimBezierLength, name: "stimBezierLength");
			stimBezierWidthFactor = s.Serialize<float>(stimBezierWidthFactor, name: "stimBezierWidthFactor");
			alphaLength = s.Serialize<float>(alphaLength, name: "alphaLength");
			useStim = s.Serialize<int>(useStim, name: "useStim");
			faction = s.Serialize<uint>(faction, name: "faction");
			useAnnunciatorFx = s.Serialize<int>(useAnnunciatorFx, name: "useAnnunciatorFx");
			durationAnnunciationFx = s.Serialize<float>(durationAnnunciationFx, name: "durationAnnunciationFx");
			modTileTexture = s.Serialize<uint>(modTileTexture, name: "modTileTexture");
			fxNameAnnunciator = s.SerializeObject<StringID>(fxNameAnnunciator, name: "fxNameAnnunciator");
			fxNameStartFFP = s.SerializeObject<StringID>(fxNameStartFFP, name: "fxNameStartFFP");
			fxNameEndFFP = s.SerializeObject<StringID>(fxNameEndFFP, name: "fxNameEndFFP");
			soundNameStartFFP = s.SerializeObject<StringID>(soundNameStartFFP, name: "soundNameStartFFP");
			soundNameAnnunciatorFFP = s.SerializeObject<StringID>(soundNameAnnunciatorFFP, name: "soundNameAnnunciatorFFP");
			usePolyline = s.Serialize<int>(usePolyline, name: "usePolyline");
			polylineLength = s.Serialize<float>(polylineLength, name: "polylineLength");
			gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			ignoreEventTrigger = s.Serialize<int>(ignoreEventTrigger, name: "ignoreEventTrigger");
		}
		public override uint? ClassCRC => 0x66F39045;
	}
}

