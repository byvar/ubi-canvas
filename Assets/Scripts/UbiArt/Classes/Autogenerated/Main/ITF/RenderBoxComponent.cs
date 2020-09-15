using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class RenderBoxComponent : GraphicComponent {
		[Serialize("imageResolution"           )] public Vec2d imageResolution;
		[Serialize("autoSize"                  )] public bool autoSize;
		[Serialize("offset"                    )] public Vec2d offset;
		[Serialize("uvPreTranslation"          )] public Vec2d uvPreTranslation;
		[Serialize("uvRatio"                   )] public Vec2d uvRatio;
		[Serialize("uvTranslation"             )] public Vec2d uvTranslation;
		[Serialize("uvRotation"                )] public Angle uvRotation;
		[Serialize("uvTranslationSpeed"        )] public Vec2d uvTranslationSpeed;
		[Serialize("uvRotationSpeed"           )] public Angle uvRotationSpeed;
		[Serialize("uvPivot"                   )] public Vec2d uvPivot;
		[Serialize("overwritematerial"         )] public GFXMaterialSerializable overwritematerial;
		[Serialize("size"                      )] public Vec2d size;
		[Serialize("Vector2__0"                )] public Vec2d Vector2__0;
		[Serialize("bool__1"                   )] public bool bool__1;
		[Serialize("Vector2__2"                )] public Vec2d Vector2__2;
		[Serialize("Vector2__3"                )] public Vec2d Vector2__3;
		[Serialize("Vector2__4"                )] public Vec2d Vector2__4;
		[Serialize("Angle__5"                  )] public Angle Angle__5;
		[Serialize("Vector2__6"                )] public Vec2d Vector2__6;
		[Serialize("Angle__7"                  )] public Angle Angle__7;
		[Serialize("Vector2__8"                )] public Vec2d Vector2__8;
		[Serialize("GFXMaterialSerializable__9")] public GFXMaterialSerializable GFXMaterialSerializable__9;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(size));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(uvPreTranslation));
				SerializeField(s, nameof(uvRatio));
				SerializeField(s, nameof(uvTranslation));
				SerializeField(s, nameof(uvRotation));
				SerializeField(s, nameof(uvTranslationSpeed));
				SerializeField(s, nameof(uvRotationSpeed));
				SerializeField(s, nameof(uvPivot));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Vector2__0));
				SerializeField(s, nameof(bool__1));
				SerializeField(s, nameof(Vector2__2));
				SerializeField(s, nameof(Vector2__3));
				SerializeField(s, nameof(Vector2__4));
				SerializeField(s, nameof(Angle__5));
				SerializeField(s, nameof(Vector2__6));
				SerializeField(s, nameof(Angle__7));
				SerializeField(s, nameof(Vector2__8));
				SerializeField(s, nameof(GFXMaterialSerializable__9));
			} else {
				SerializeField(s, nameof(imageResolution));
				SerializeField(s, nameof(autoSize));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(uvPreTranslation));
				SerializeField(s, nameof(uvRatio));
				SerializeField(s, nameof(uvTranslation));
				SerializeField(s, nameof(uvRotation));
				SerializeField(s, nameof(uvTranslationSpeed));
				SerializeField(s, nameof(uvRotationSpeed));
				SerializeField(s, nameof(uvPivot));
				SerializeField(s, nameof(overwritematerial));
			}
		}
		public override uint? ClassCRC => 0xEB0C05CF;
	}
}

