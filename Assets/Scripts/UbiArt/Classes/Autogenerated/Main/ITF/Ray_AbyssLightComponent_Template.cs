using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AbyssLightComponent_Template : LightComponent_Template {
		[Serialize("radius"            )] public float radius;
		[Serialize("useTexture"        )] public int useTexture;
		[Serialize("texturePath"       )] public Path texturePath;
		[Serialize("textureRenderPrio" )] public float textureRenderPrio;
		[Serialize("textureRadiusRatio")] public float textureRadiusRatio;
		[Serialize("boneName"          )] public StringID boneName;
		[Serialize("variationMinTime"  )] public float variationMinTime;
		[Serialize("variationMaxTime"  )] public float variationMaxTime;
		[Serialize("alphaVariation"    )] public float alphaVariation;
		[Serialize("sizeVariation"     )] public float sizeVariation;
		[Serialize("positionVariation" )] public float positionVariation;
		[Serialize("soundName"         )] public StringID soundName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(radius));
			SerializeField(s, nameof(useTexture));
			SerializeField(s, nameof(texturePath));
			SerializeField(s, nameof(textureRenderPrio));
			SerializeField(s, nameof(textureRadiusRatio));
			SerializeField(s, nameof(boneName));
			SerializeField(s, nameof(variationMinTime));
			SerializeField(s, nameof(variationMaxTime));
			SerializeField(s, nameof(alphaVariation));
			SerializeField(s, nameof(sizeVariation));
			SerializeField(s, nameof(positionVariation));
			SerializeField(s, nameof(soundName));
		}
		public override uint? ClassCRC => 0x5FD3036C;
	}
}

