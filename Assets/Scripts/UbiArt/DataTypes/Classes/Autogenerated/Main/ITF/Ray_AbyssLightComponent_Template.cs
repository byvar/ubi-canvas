namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AbyssLightComponent_Template : LightComponent_Template {
		public float radius;
		public int useTexture;
		public Path texturePath;
		public float textureRenderPrio;
		public float textureRadiusRatio;
		public StringID boneName;
		public float variationMinTime;
		public float variationMaxTime;
		public float alphaVariation;
		public float sizeVariation;
		public float positionVariation;
		public StringID soundName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			radius = s.Serialize<float>(radius, name: "radius");
			useTexture = s.Serialize<int>(useTexture, name: "useTexture");
			texturePath = s.SerializeObject<Path>(texturePath, name: "texturePath");
			textureRenderPrio = s.Serialize<float>(textureRenderPrio, name: "textureRenderPrio");
			textureRadiusRatio = s.Serialize<float>(textureRadiusRatio, name: "textureRadiusRatio");
			boneName = s.SerializeObject<StringID>(boneName, name: "boneName");
			variationMinTime = s.Serialize<float>(variationMinTime, name: "variationMinTime");
			variationMaxTime = s.Serialize<float>(variationMaxTime, name: "variationMaxTime");
			alphaVariation = s.Serialize<float>(alphaVariation, name: "alphaVariation");
			sizeVariation = s.Serialize<float>(sizeVariation, name: "sizeVariation");
			positionVariation = s.Serialize<float>(positionVariation, name: "positionVariation");
			soundName = s.SerializeObject<StringID>(soundName, name: "soundName");
		}
		public override uint? ClassCRC => 0x5FD3036C;
	}
}

