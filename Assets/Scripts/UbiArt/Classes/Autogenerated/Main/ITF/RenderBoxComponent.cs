using UnityEngine;

namespace UbiArt.ITF {
	public partial class RenderBoxComponent : GraphicComponent {
		[Serialize("imageResolution"   )] public Vector2 imageResolution;
		[Serialize("autoSize"          )] public bool autoSize;
		[Serialize("offset"            )] public Vector2 offset;
		[Serialize("uvPreTranslation"  )] public Vector2 uvPreTranslation;
		[Serialize("uvRatio"           )] public Vector2 uvRatio;
		[Serialize("uvTranslation"     )] public Vector2 uvTranslation;
		[Serialize("uvRotation"        )] public Angle uvRotation;
		[Serialize("uvTranslationSpeed")] public Vector2 uvTranslationSpeed;
		[Serialize("uvRotationSpeed"   )] public Angle uvRotationSpeed;
		[Serialize("uvPivot"           )] public Vector2 uvPivot;
		[Serialize("overwritematerial" )] public GFXMaterialSerializable overwritematerial;
		[Serialize("size"              )] public Vector2 size;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(size));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(uvPreTranslation));
				SerializeField(s, nameof(uvRatio));
				SerializeField(s, nameof(uvTranslation));
				SerializeField(s, nameof(uvRotation));
				SerializeField(s, nameof(uvTranslationSpeed));
				SerializeField(s, nameof(uvRotationSpeed));
				SerializeField(s, nameof(uvPivot));
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

