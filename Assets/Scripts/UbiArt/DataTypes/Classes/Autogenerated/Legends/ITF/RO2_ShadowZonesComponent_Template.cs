namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShadowZonesComponent_Template : ActorComponent_Template {
		public Path lightTexture;
		public GFXMaterialSerializable lightMaterial;
		public float lightRadius;
		public float lightLateralAttenuation;
		public float lightLateralAlpha;
		public float lightExternalAttenuation;
		public float lightExternalAlpha;
		public float lightShapeDiscretization;
		public float lightMeshDiscretization;
		public float lightUVx0;
		public float lightUVx1;
		public float lightUVx2;
		public float lightUVx3;
		public float lightUVy0;
		public float lightUVy1;
		public float lightUVy2;
		public Vec2d lightUVRatio;
		public Vec2d lightUVTranslation;
		public Angle lightUVRotation;
		public Vec2d lightUVTranslationSpeed;
		public Angle lightUVRotationSpeed;
		public Vec2d lightUVPivot;
		public Path backLightTexture;
		public GFXMaterialSerializable backLightMaterial;
		public float backLightOffset;
		public Path shadowTexture;
		public GFXMaterialSerializable shadowMaterial;
		public Path backShadowTexture;
		public GFXMaterialSerializable backShadowMaterial;
		public float backShadowOffset;
		public float shadowOffset;
		public float shadowLateralAttenuation;
		public float shadowLateralAlpha;
		public float shadowUVx0;
		public float shadowUVx1;
		public float shadowUVx2;
		public float shadowUVx3;
		public float shadowUVx1Quad;
		public float shadowUVx2Quad;
		public int smoothAllEdges;

		public float Vita_00 { get; set; }
		public float Vita_01 { get; set; }

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				lightTexture = s.SerializeObject<Path>(lightTexture, name: "lightTexture");
			}
			lightMaterial = s.SerializeObject<GFXMaterialSerializable>(lightMaterial, name: "lightMaterial");
			lightRadius = s.Serialize<float>(lightRadius, name: "lightRadius");
			lightLateralAttenuation = s.Serialize<float>(lightLateralAttenuation, name: "lightLateralAttenuation");
			lightLateralAlpha = s.Serialize<float>(lightLateralAlpha, name: "lightLateralAlpha");
			lightExternalAttenuation = s.Serialize<float>(lightExternalAttenuation, name: "lightExternalAttenuation");
			lightExternalAlpha = s.Serialize<float>(lightExternalAlpha, name: "lightExternalAlpha");
			lightShapeDiscretization = s.Serialize<float>(lightShapeDiscretization, name: "lightShapeDiscretization");
			lightMeshDiscretization = s.Serialize<float>(lightMeshDiscretization, name: "lightMeshDiscretization");
			lightUVx0 = s.Serialize<float>(lightUVx0, name: "lightUVx0");
			lightUVx1 = s.Serialize<float>(lightUVx1, name: "lightUVx1");
			lightUVx2 = s.Serialize<float>(lightUVx2, name: "lightUVx2");
			lightUVx3 = s.Serialize<float>(lightUVx3, name: "lightUVx3");
			lightUVy0 = s.Serialize<float>(lightUVy0, name: "lightUVy0");
			lightUVy1 = s.Serialize<float>(lightUVy1, name: "lightUVy1");
			lightUVy2 = s.Serialize<float>(lightUVy2, name: "lightUVy2");
			lightUVRatio = s.SerializeObject<Vec2d>(lightUVRatio, name: "lightUVRatio");
			lightUVTranslation = s.SerializeObject<Vec2d>(lightUVTranslation, name: "lightUVTranslation");
			lightUVRotation = s.SerializeObject<Angle>(lightUVRotation, name: "lightUVRotation");
			lightUVTranslationSpeed = s.SerializeObject<Vec2d>(lightUVTranslationSpeed, name: "lightUVTranslationSpeed");
			lightUVRotationSpeed = s.SerializeObject<Angle>(lightUVRotationSpeed, name: "lightUVRotationSpeed");
			lightUVPivot = s.SerializeObject<Vec2d>(lightUVPivot, name: "lightUVPivot");
			if (s.HasFlags(SerializeFlags.Flags8)) {
				backLightTexture = s.SerializeObject<Path>(backLightTexture, name: "backLightTexture");
			}
			backLightMaterial = s.SerializeObject<GFXMaterialSerializable>(backLightMaterial, name: "backLightMaterial");
			backLightOffset = s.Serialize<float>(backLightOffset, name: "backLightOffset");
			if (s.HasFlags(SerializeFlags.Flags8)) {
				shadowTexture = s.SerializeObject<Path>(shadowTexture, name: "shadowTexture");
			}
			shadowMaterial = s.SerializeObject<GFXMaterialSerializable>(shadowMaterial, name: "shadowMaterial");
			if (s.HasFlags(SerializeFlags.Flags8)) {
				backShadowTexture = s.SerializeObject<Path>(backShadowTexture, name: "backShadowTexture");
			}
			backShadowMaterial = s.SerializeObject<GFXMaterialSerializable>(backShadowMaterial, name: "backShadowMaterial");
			backShadowOffset = s.Serialize<float>(backShadowOffset, name: "backShadowOffset");
			shadowOffset = s.Serialize<float>(shadowOffset, name: "shadowOffset");
			shadowLateralAttenuation = s.Serialize<float>(shadowLateralAttenuation, name: "shadowLateralAttenuation");
			shadowLateralAlpha = s.Serialize<float>(shadowLateralAlpha, name: "shadowLateralAlpha");
			shadowUVx0 = s.Serialize<float>(shadowUVx0, name: "shadowUVx0");
			shadowUVx1 = s.Serialize<float>(shadowUVx1, name: "shadowUVx1");
			shadowUVx2 = s.Serialize<float>(shadowUVx2, name: "shadowUVx2");
			shadowUVx3 = s.Serialize<float>(shadowUVx3, name: "shadowUVx3");
			shadowUVx1Quad = s.Serialize<float>(shadowUVx1Quad, name: "shadowUVx1Quad");
			shadowUVx2Quad = s.Serialize<float>(shadowUVx2Quad, name: "shadowUVx2Quad");

			if (s.Settings.platform == Settings.Platform.Vita) {
				Vita_00 = s.Serialize<float>(Vita_00, name: nameof(Vita_00));
				Vita_01 = s.Serialize<float>(Vita_01, name: nameof(Vita_01));
			}

			smoothAllEdges = s.Serialize<int>(smoothAllEdges, name: "smoothAllEdges");
		}
		public override uint? ClassCRC => 0xAD8E713C;
	}
}

