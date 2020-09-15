using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AbyssLightComponent_Template : ActorComponent_Template {
		public float radius;
		public float textureRenderPrio;
		public float textureRadiusRatio;
		public StringID boneName;
		public float variationMinTime;
		public float variationMaxTime;
		public float alphaVariation;
		public float sizeVariation;
		public float positionVariation;
		public StringID soundName;
		public GFXMaterialSerializable mat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				radius = s.Serialize<float>(radius, name: "radius");
				textureRenderPrio = s.Serialize<float>(textureRenderPrio, name: "textureRenderPrio");
				textureRadiusRatio = s.Serialize<float>(textureRadiusRatio, name: "textureRadiusRatio");
				boneName = s.SerializeObject<StringID>(boneName, name: "boneName");
				variationMinTime = s.Serialize<float>(variationMinTime, name: "variationMinTime");
				variationMaxTime = s.Serialize<float>(variationMaxTime, name: "variationMaxTime");
				alphaVariation = s.Serialize<float>(alphaVariation, name: "alphaVariation");
				sizeVariation = s.Serialize<float>(sizeVariation, name: "sizeVariation");
				positionVariation = s.Serialize<float>(positionVariation, name: "positionVariation");
				soundName = s.SerializeObject<StringID>(soundName, name: "soundName");
			} else {
				radius = s.Serialize<float>(radius, name: "radius");
				textureRenderPrio = s.Serialize<float>(textureRenderPrio, name: "textureRenderPrio");
				textureRadiusRatio = s.Serialize<float>(textureRadiusRatio, name: "textureRadiusRatio");
				boneName = s.SerializeObject<StringID>(boneName, name: "boneName");
				variationMinTime = s.Serialize<float>(variationMinTime, name: "variationMinTime");
				variationMaxTime = s.Serialize<float>(variationMaxTime, name: "variationMaxTime");
				alphaVariation = s.Serialize<float>(alphaVariation, name: "alphaVariation");
				sizeVariation = s.Serialize<float>(sizeVariation, name: "sizeVariation");
				positionVariation = s.Serialize<float>(positionVariation, name: "positionVariation");
				soundName = s.SerializeObject<StringID>(soundName, name: "soundName");
				mat = s.SerializeObject<GFXMaterialSerializable>(mat, name: "mat");
			}
		}
		public override uint? ClassCRC => 0x0C28BD33;
	}
}

