namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class RenderBoxComponent : GraphicComponent {
		public Vec2d imageResolution = new Vec2d(100,100);
		public bool autoSize;
		public Vec2d offset;
		public Vec2d uvPreTranslation;
		public Vec2d uvRatio = Vec2d.One;
		public Vec2d uvTranslation;
		public Angle uvRotation;
		public Vec2d uvTranslationSpeed;
		public Angle uvRotationSpeed;
		public Vec2d uvPivot;
		public GFXMaterialSerializable overwritematerial;
		public Vec2d size = Vec2d.One;
		public Vec2d scale = Vec2d.One;
		public Vec2d Vector2__2;
		public Vec2d Vector2__3;
		public Vec2d Vector2__4;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				size = s.SerializeObject<Vec2d>(size, name: "size");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
				uvPreTranslation = s.SerializeObject<Vec2d>(uvPreTranslation, name: "uvPreTranslation");
				uvRatio = s.SerializeObject<Vec2d>(uvRatio, name: "uvRatio");
				uvTranslation = s.SerializeObject<Vec2d>(uvTranslation, name: "uvTranslation");
				uvRotation = s.SerializeObject<Angle>(uvRotation, name: "uvRotation");
				uvTranslationSpeed = s.SerializeObject<Vec2d>(uvTranslationSpeed, name: "uvTranslationSpeed");
				uvRotationSpeed = s.SerializeObject<Angle>(uvRotationSpeed, name: "uvRotationSpeed");
				uvPivot = s.SerializeObject<Vec2d>(uvPivot, name: "uvPivot");
			} else if (s.Settings.Game == Game.VH) {
				imageResolution = s.SerializeObject<Vec2d>(imageResolution, name: "imageResolution");
				autoSize = s.Serialize<bool>(autoSize, name: "autoSize");
				Vector2__2 = s.SerializeObject<Vec2d>(Vector2__2, name: "Vector2__2");
				Vector2__3 = s.SerializeObject<Vec2d>(Vector2__3, name: "Vector2__3");
				Vector2__4 = s.SerializeObject<Vec2d>(Vector2__4, name: "Vector2__4");
				uvRotation = s.SerializeObject<Angle>(uvRotation, name: "uvRotation");
				uvTranslationSpeed = s.SerializeObject<Vec2d>(uvTranslationSpeed, name: "uvTranslationSpeed");
				uvRotationSpeed = s.SerializeObject<Angle>(uvRotationSpeed, name: "uvRotationSpeed");
				uvPivot = s.SerializeObject<Vec2d>(uvPivot, name: "uvPivot");
				overwritematerial = s.SerializeObject<GFXMaterialSerializable>(overwritematerial, name: "overwritematerial");
			} else {
				imageResolution = s.SerializeObject<Vec2d>(imageResolution, name: "imageResolution");
				autoSize = s.Serialize<bool>(autoSize, name: "autoSize");
				if (!autoSize) {
					size = s.SerializeObject<Vec2d>(size, name: "size");
				} else {
					scale = s.SerializeObject<Vec2d>(scale, name: "scale");
				}
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
				uvPreTranslation = s.SerializeObject<Vec2d>(uvPreTranslation, name: "uvPreTranslation");
				if (!autoSize) {
					uvRatio = s.SerializeObject<Vec2d>(uvRatio, name: "uvRatio");
				}
				uvTranslation = s.SerializeObject<Vec2d>(uvTranslation, name: "uvTranslation");
				uvRotation = s.SerializeObject<Angle>(uvRotation, name: "uvRotation");
				uvTranslationSpeed = s.SerializeObject<Vec2d>(uvTranslationSpeed, name: "uvTranslationSpeed");
				uvRotationSpeed = s.SerializeObject<Angle>(uvRotationSpeed, name: "uvRotationSpeed");
				uvPivot = s.SerializeObject<Vec2d>(uvPivot, name: "uvPivot");
				overwritematerial = s.SerializeObject<GFXMaterialSerializable>(overwritematerial, name: "overwritematerial");
			}
		}
		public override uint? ClassCRC => 0xEB0C05CF;
	}
}

