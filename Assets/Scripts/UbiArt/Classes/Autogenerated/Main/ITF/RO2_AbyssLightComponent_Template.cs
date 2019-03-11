using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AbyssLightComponent_Template : ActorComponent_Template {
		[Serialize("radius"            )] public float radius;
		[Serialize("textureRenderPrio" )] public float textureRenderPrio;
		[Serialize("textureRadiusRatio")] public float textureRadiusRatio;
		[Serialize("boneName"          )] public StringID boneName;
		[Serialize("variationMinTime"  )] public float variationMinTime;
		[Serialize("variationMaxTime"  )] public float variationMaxTime;
		[Serialize("alphaVariation"    )] public float alphaVariation;
		[Serialize("sizeVariation"     )] public float sizeVariation;
		[Serialize("positionVariation" )] public float positionVariation;
		[Serialize("soundName"         )] public StringID soundName;
		[Serialize("mat"               )] public GFXMaterialSerializable mat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(radius));
				SerializeField(s, nameof(textureRenderPrio));
				SerializeField(s, nameof(textureRadiusRatio));
				SerializeField(s, nameof(boneName));
				SerializeField(s, nameof(variationMinTime));
				SerializeField(s, nameof(variationMaxTime));
				SerializeField(s, nameof(alphaVariation));
				SerializeField(s, nameof(sizeVariation));
				SerializeField(s, nameof(positionVariation));
				SerializeField(s, nameof(soundName));
			} else {
				SerializeField(s, nameof(radius));
				SerializeField(s, nameof(textureRenderPrio));
				SerializeField(s, nameof(textureRadiusRatio));
				SerializeField(s, nameof(boneName));
				SerializeField(s, nameof(variationMinTime));
				SerializeField(s, nameof(variationMaxTime));
				SerializeField(s, nameof(alphaVariation));
				SerializeField(s, nameof(sizeVariation));
				SerializeField(s, nameof(positionVariation));
				SerializeField(s, nameof(soundName));
				SerializeField(s, nameof(mat));
			}
		}
		public override uint? ClassCRC => 0x0C28BD33;
	}
}

