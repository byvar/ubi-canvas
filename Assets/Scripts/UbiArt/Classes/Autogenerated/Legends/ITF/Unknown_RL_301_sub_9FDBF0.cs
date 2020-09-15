using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_301_sub_9FDBF0 : ActorComponent_Template {
		[Serialize("lightTexture"            )] public Path lightTexture;
		[Serialize("lightMaterial"           )] public GFXMaterialSerializable lightMaterial;
		[Serialize("lightRadius"             )] public float lightRadius;
		[Serialize("lightLateralAttenuation" )] public float lightLateralAttenuation;
		[Serialize("lightLateralAlpha"       )] public float lightLateralAlpha;
		[Serialize("lightExternalAttenuation")] public float lightExternalAttenuation;
		[Serialize("lightExternalAlpha"      )] public float lightExternalAlpha;
		[Serialize("lightShapeDiscretization")] public float lightShapeDiscretization;
		[Serialize("lightMeshDiscretization" )] public float lightMeshDiscretization;
		[Serialize("lightUVx0"               )] public float lightUVx0;
		[Serialize("lightUVx1"               )] public float lightUVx1;
		[Serialize("lightUVx2"               )] public float lightUVx2;
		[Serialize("lightUVx3"               )] public float lightUVx3;
		[Serialize("lightUVy0"               )] public float lightUVy0;
		[Serialize("lightUVy1"               )] public float lightUVy1;
		[Serialize("lightUVy2"               )] public float lightUVy2;
		[Serialize("lightUVRatio"            )] public Vec2d lightUVRatio;
		[Serialize("lightUVTranslation"      )] public Vec2d lightUVTranslation;
		[Serialize("lightUVRotation"         )] public Angle lightUVRotation;
		[Serialize("lightUVTranslationSpeed" )] public Vec2d lightUVTranslationSpeed;
		[Serialize("lightUVRotationSpeed"    )] public Angle lightUVRotationSpeed;
		[Serialize("lightUVPivot"            )] public Vec2d lightUVPivot;
		[Serialize("backLightTexture"        )] public Path backLightTexture;
		[Serialize("backLightMaterial"       )] public GFXMaterialSerializable backLightMaterial;
		[Serialize("backLightOffset"         )] public float backLightOffset;
		[Serialize("shadowTexture"           )] public Path shadowTexture;
		[Serialize("shadowMaterial"          )] public GFXMaterialSerializable shadowMaterial;
		[Serialize("backShadowTexture"       )] public Path backShadowTexture;
		[Serialize("backShadowMaterial"      )] public GFXMaterialSerializable backShadowMaterial;
		[Serialize("backShadowOffset"        )] public float backShadowOffset;
		[Serialize("shadowOffset"            )] public float shadowOffset;
		[Serialize("shadowLateralAttenuation")] public float shadowLateralAttenuation;
		[Serialize("shadowLateralAlpha"      )] public float shadowLateralAlpha;
		[Serialize("shadowUVx0"              )] public float shadowUVx0;
		[Serialize("shadowUVx1"              )] public float shadowUVx1;
		[Serialize("shadowUVx2"              )] public float shadowUVx2;
		[Serialize("shadowUVx3"              )] public float shadowUVx3;
		[Serialize("shadowUVx1Quad"          )] public float shadowUVx1Quad;
		[Serialize("shadowUVx2Quad"          )] public float shadowUVx2Quad;
		[Serialize("smoothAllEdges"          )] public int smoothAllEdges;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(lightTexture));
			}
			SerializeField(s, nameof(lightMaterial));
			SerializeField(s, nameof(lightRadius));
			SerializeField(s, nameof(lightLateralAttenuation));
			SerializeField(s, nameof(lightLateralAlpha));
			SerializeField(s, nameof(lightExternalAttenuation));
			SerializeField(s, nameof(lightExternalAlpha));
			SerializeField(s, nameof(lightShapeDiscretization));
			SerializeField(s, nameof(lightMeshDiscretization));
			SerializeField(s, nameof(lightUVx0));
			SerializeField(s, nameof(lightUVx1));
			SerializeField(s, nameof(lightUVx2));
			SerializeField(s, nameof(lightUVx3));
			SerializeField(s, nameof(lightUVy0));
			SerializeField(s, nameof(lightUVy1));
			SerializeField(s, nameof(lightUVy2));
			SerializeField(s, nameof(lightUVRatio));
			SerializeField(s, nameof(lightUVTranslation));
			SerializeField(s, nameof(lightUVRotation));
			SerializeField(s, nameof(lightUVTranslationSpeed));
			SerializeField(s, nameof(lightUVRotationSpeed));
			SerializeField(s, nameof(lightUVPivot));
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(backLightTexture));
			}
			SerializeField(s, nameof(backLightMaterial));
			SerializeField(s, nameof(backLightOffset));
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(shadowTexture));
			}
			SerializeField(s, nameof(shadowMaterial));
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(backShadowTexture));
			}
			SerializeField(s, nameof(backShadowMaterial));
			SerializeField(s, nameof(backShadowOffset));
			SerializeField(s, nameof(shadowOffset));
			SerializeField(s, nameof(shadowLateralAttenuation));
			SerializeField(s, nameof(shadowLateralAlpha));
			SerializeField(s, nameof(shadowUVx0));
			SerializeField(s, nameof(shadowUVx1));
			SerializeField(s, nameof(shadowUVx2));
			SerializeField(s, nameof(shadowUVx3));
			SerializeField(s, nameof(shadowUVx1Quad));
			SerializeField(s, nameof(shadowUVx2Quad));
			SerializeField(s, nameof(smoothAllEdges));
		}
		public override uint? ClassCRC => 0xAD8E713C;
	}
}

