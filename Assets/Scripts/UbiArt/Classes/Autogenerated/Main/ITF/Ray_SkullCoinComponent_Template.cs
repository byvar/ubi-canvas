using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_SkullCoinComponent_Template : GraphicComponent_Template {
		[Serialize("lumCount"                  )] public uint lumCount;
		[Serialize("challengeDuration"         )] public float challengeDuration;
		[Serialize("bezierUPerMeter"           )] public float bezierUPerMeter;
		[Serialize("bezierStartWidth"          )] public float bezierStartWidth;
		[Serialize("bezierEndWidth"            )] public float bezierEndWidth;
		[Serialize("tesselationLength"         )] public float tesselationLength;
		[Serialize("blendMode"                 )] public uint blendMode;
		[Serialize("texture"                   )] public Path texture;
		[Serialize("backToNormalSpeed"         )] public float backToNormalSpeed;
		[Serialize("minPulsation"              )] public float minPulsation;
		[Serialize("maxPulsation"              )] public float maxPulsation;
		[Serialize("minScaleAtStart"           )] public float minScaleAtStart;
		[Serialize("maxScaleAtStart"           )] public float maxScaleAtStart;
		[Serialize("minScaleAtEnd"             )] public float minScaleAtEnd;
		[Serialize("maxScaleAtEnd"             )] public float maxScaleAtEnd;
		[Serialize("linkPulsation"             )] public float linkPulsation;
		[Serialize("linkAmplitude"             )] public float linkAmplitude;
		[Serialize("playerFollowOffset"        )] public Vector2 playerFollowOffset;
		[Serialize("speedBlend"                )] public float speedBlend;
		[Serialize("speedMin"                  )] public float speedMin;
		[Serialize("speedMax"                  )] public float speedMax;
		[Serialize("blendAtSpeedMin"           )] public float blendAtSpeedMin;
		[Serialize("blendAtSpeedMax"           )] public float blendAtSpeedMax;
		[Serialize("backToNormalInertia"       )] public float backToNormalInertia;
		[Serialize("backToNormalBounciness"    )] public float backToNormalBounciness;
		[Serialize("backToNormalInitSpeed"     )] public float backToNormalInitSpeed;
		[Serialize("maxDistanceBeforeExploding")] public float maxDistanceBeforeExploding;
		[Serialize("radius"                    )] public float radius;
		[Serialize("minLinkThicknessFactor"    )] public float minLinkThicknessFactor;
		[Serialize("lenghtForMinThickness"     )] public float lenghtForMinThickness;
		[Serialize("uvAnimTrans"               )] public Vector2 uvAnimTrans;
		[Serialize("startAlphaLen"             )] public float startAlphaLen;
		[Serialize("endAlphaLen"               )] public float endAlphaLen;
		[Serialize("linkAlphaMultiplier"       )] public float linkAlphaMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lumCount));
			SerializeField(s, nameof(challengeDuration));
			SerializeField(s, nameof(bezierUPerMeter));
			SerializeField(s, nameof(bezierStartWidth));
			SerializeField(s, nameof(bezierEndWidth));
			SerializeField(s, nameof(tesselationLength));
			SerializeField(s, nameof(blendMode));
			SerializeField(s, nameof(texture));
			SerializeField(s, nameof(backToNormalSpeed));
			SerializeField(s, nameof(minPulsation));
			SerializeField(s, nameof(maxPulsation));
			SerializeField(s, nameof(minScaleAtStart));
			SerializeField(s, nameof(maxScaleAtStart));
			SerializeField(s, nameof(minScaleAtEnd));
			SerializeField(s, nameof(maxScaleAtEnd));
			SerializeField(s, nameof(linkPulsation));
			SerializeField(s, nameof(linkAmplitude));
			SerializeField(s, nameof(playerFollowOffset));
			SerializeField(s, nameof(speedBlend));
			SerializeField(s, nameof(speedMin));
			SerializeField(s, nameof(speedMax));
			SerializeField(s, nameof(blendAtSpeedMin));
			SerializeField(s, nameof(blendAtSpeedMax));
			SerializeField(s, nameof(backToNormalInertia));
			SerializeField(s, nameof(backToNormalBounciness));
			SerializeField(s, nameof(backToNormalInitSpeed));
			SerializeField(s, nameof(maxDistanceBeforeExploding));
			SerializeField(s, nameof(radius));
			SerializeField(s, nameof(minLinkThicknessFactor));
			SerializeField(s, nameof(lenghtForMinThickness));
			SerializeField(s, nameof(uvAnimTrans));
			SerializeField(s, nameof(startAlphaLen));
			SerializeField(s, nameof(endAlphaLen));
			SerializeField(s, nameof(linkAlphaMultiplier));
		}
		public override uint? ClassCRC => 0xA15FEC50;
	}
}

