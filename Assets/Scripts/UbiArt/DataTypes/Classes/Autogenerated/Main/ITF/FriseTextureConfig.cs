namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class FriseTextureConfig : CSerializable {
		public Path path;
		public GFXMaterialSerializable material;
		public StringID friendly;
		public Path gameMaterial;
		public ColorInteger color = new ColorInteger(1, 1, 1, 1);
		public float fillingOffset = float.MaxValue;
		public CollisionTexture collision;
		public Vec2d scrollUV;
		public float scrollAngle;
		public bool useUV2;
		public Vec2d scaleUV2 = Vec2d.One;
		public Vec2d scrollUV2;
		public float scrollAngle2;
		public byte alphaBorder = 0xff;
		public byte alphaUp = 0xff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				path = s.SerializeObject<Path>(path, name: "path");
			}
			material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
			friendly = s.SerializeObject<StringID>(friendly, name: "friendly");
			gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
			color = s.SerializeObject<ColorInteger>(color, name: "color");
			fillingOffset = s.Serialize<float>(fillingOffset, name: "fillingOffset");
			collision = s.SerializeObject<CollisionTexture>(collision, name: "collision");
			scrollUV = s.SerializeObject<Vec2d>(scrollUV, name: "scrollUV");
			scrollAngle = s.Serialize<float>(scrollAngle, name: "scrollAngle");
			if (s.Settings.game == Settings.Game.COL) {
				useUV2 = s.Serialize<bool>(useUV2, name: "useUV2", options: CSerializerObject.Options.BoolAsByte);
			} else {
				useUV2 = s.Serialize<bool>(useUV2, name: "useUV2");
			}
			scaleUV2 = s.SerializeObject<Vec2d>(scaleUV2, name: "scaleUV2");
			scrollUV2 = s.SerializeObject<Vec2d>(scrollUV2, name: "scrollUV2");
			scrollAngle2 = s.Serialize<float>(scrollAngle2, name: "scrollAngle2");
			alphaBorder = s.Serialize<byte>(alphaBorder, name: "alphaBorder");
			alphaUp = s.Serialize<byte>(alphaUp, name: "alphaUp");
		}
	}
}

