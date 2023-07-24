namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_GFXMaterialShader_Layer_UVModifier : CSerializable {
		public float TranslationU;
		public float TranslationV;
		public int AnimTranslationU;
		public int AnimTranslationV;
		public float Rotation;
		public float RotationOffsetU;
		public float RotationOffsetV;
		public int AnimRotation;
		public float ScaleU;
		public float ScaleV;
		public float ScaleOffsetU;
		public float ScaleOffsetV;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			TranslationU = s.Serialize<float>(TranslationU, name: "TranslationU");
			TranslationV = s.Serialize<float>(TranslationV, name: "TranslationV");
			AnimTranslationU = s.Serialize<int>(AnimTranslationU, name: "AnimTranslationU");
			AnimTranslationV = s.Serialize<int>(AnimTranslationV, name: "AnimTranslationV");
			Rotation = s.Serialize<float>(Rotation, name: "Rotation");
			RotationOffsetU = s.Serialize<float>(RotationOffsetU, name: "RotationOffsetU");
			RotationOffsetV = s.Serialize<float>(RotationOffsetV, name: "RotationOffsetV");
			AnimRotation = s.Serialize<int>(AnimRotation, name: "AnimRotation");
			ScaleU = s.Serialize<float>(ScaleU, name: "ScaleU");
			ScaleV = s.Serialize<float>(ScaleV, name: "ScaleV");
			ScaleOffsetU = s.Serialize<float>(ScaleOffsetU, name: "ScaleOffsetU");
			ScaleOffsetV = s.Serialize<float>(ScaleOffsetV, name: "ScaleOffsetV");
		}
	}
}
