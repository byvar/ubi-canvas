namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class RenderBoxComponent : GraphicComponent {
		public Vec2d imageResolution;
		public bool autoSize;
		public Vec2d offset;
		public Vec2d uvPreTranslation;
		public Vec2d uvRatio;
		public Vec2d uvTranslation;
		public Angle uvRotation;
		public Vec2d uvTranslationSpeed;
		public Angle uvRotationSpeed;
		public Vec2d uvPivot;
		public GFXMaterialSerializable overwritematerial;
		public Vec2d size;
		public Vec2d Vector2__0;
		public bool bool__1;
		public Vec2d Vector2__2;
		public Vec2d Vector2__3;
		public Vec2d Vector2__4;
		public Angle Angle__5;
		public Vec2d Vector2__6;
		public Angle Angle__7;
		public Vec2d Vector2__8;
		public GFXMaterialSerializable GFXMaterialSerializable__9;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				size = s.SerializeObject<Vec2d>(size, name: "size");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
				uvPreTranslation = s.SerializeObject<Vec2d>(uvPreTranslation, name: "uvPreTranslation");
				uvRatio = s.SerializeObject<Vec2d>(uvRatio, name: "uvRatio");
				uvTranslation = s.SerializeObject<Vec2d>(uvTranslation, name: "uvTranslation");
				uvRotation = s.SerializeObject<Angle>(uvRotation, name: "uvRotation");
				uvTranslationSpeed = s.SerializeObject<Vec2d>(uvTranslationSpeed, name: "uvTranslationSpeed");
				uvRotationSpeed = s.SerializeObject<Angle>(uvRotationSpeed, name: "uvRotationSpeed");
				uvPivot = s.SerializeObject<Vec2d>(uvPivot, name: "uvPivot");
			} else if (s.Settings.game == Settings.Game.VH) {
				Vector2__0 = s.SerializeObject<Vec2d>(Vector2__0, name: "Vector2__0");
				bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
				Vector2__2 = s.SerializeObject<Vec2d>(Vector2__2, name: "Vector2__2");
				Vector2__3 = s.SerializeObject<Vec2d>(Vector2__3, name: "Vector2__3");
				Vector2__4 = s.SerializeObject<Vec2d>(Vector2__4, name: "Vector2__4");
				Angle__5 = s.SerializeObject<Angle>(Angle__5, name: "Angle__5");
				Vector2__6 = s.SerializeObject<Vec2d>(Vector2__6, name: "Vector2__6");
				Angle__7 = s.SerializeObject<Angle>(Angle__7, name: "Angle__7");
				Vector2__8 = s.SerializeObject<Vec2d>(Vector2__8, name: "Vector2__8");
				GFXMaterialSerializable__9 = s.SerializeObject<GFXMaterialSerializable>(GFXMaterialSerializable__9, name: "GFXMaterialSerializable__9");
			} else {
				imageResolution = s.SerializeObject<Vec2d>(imageResolution, name: "imageResolution");
				autoSize = s.Serialize<bool>(autoSize, name: "autoSize");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
				uvPreTranslation = s.SerializeObject<Vec2d>(uvPreTranslation, name: "uvPreTranslation");
				uvRatio = s.SerializeObject<Vec2d>(uvRatio, name: "uvRatio");
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

