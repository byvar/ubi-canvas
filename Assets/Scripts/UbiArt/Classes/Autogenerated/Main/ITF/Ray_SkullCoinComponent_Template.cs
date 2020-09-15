using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_SkullCoinComponent_Template : GraphicComponent_Template {
		public uint lumCount;
		public float challengeDuration;
		public float bezierUPerMeter;
		public float bezierStartWidth;
		public float bezierEndWidth;
		public float tesselationLength;
		public uint blendMode;
		public Path texture;
		public float backToNormalSpeed;
		public float minPulsation;
		public float maxPulsation;
		public float minScaleAtStart;
		public float maxScaleAtStart;
		public float minScaleAtEnd;
		public float maxScaleAtEnd;
		public float linkPulsation;
		public float linkAmplitude;
		public Vec2d playerFollowOffset;
		public float speedBlend;
		public float speedMin;
		public float speedMax;
		public float blendAtSpeedMin;
		public float blendAtSpeedMax;
		public float backToNormalInertia;
		public float backToNormalBounciness;
		public float backToNormalInitSpeed;
		public float maxDistanceBeforeExploding;
		public float radius;
		public float minLinkThicknessFactor;
		public float lenghtForMinThickness;
		public Vec2d uvAnimTrans;
		public float startAlphaLen;
		public float endAlphaLen;
		public float linkAlphaMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lumCount = s.Serialize<uint>(lumCount, name: "lumCount");
			challengeDuration = s.Serialize<float>(challengeDuration, name: "challengeDuration");
			bezierUPerMeter = s.Serialize<float>(bezierUPerMeter, name: "bezierUPerMeter");
			bezierStartWidth = s.Serialize<float>(bezierStartWidth, name: "bezierStartWidth");
			bezierEndWidth = s.Serialize<float>(bezierEndWidth, name: "bezierEndWidth");
			tesselationLength = s.Serialize<float>(tesselationLength, name: "tesselationLength");
			blendMode = s.Serialize<uint>(blendMode, name: "blendMode");
			texture = s.SerializeObject<Path>(texture, name: "texture");
			backToNormalSpeed = s.Serialize<float>(backToNormalSpeed, name: "backToNormalSpeed");
			minPulsation = s.Serialize<float>(minPulsation, name: "minPulsation");
			maxPulsation = s.Serialize<float>(maxPulsation, name: "maxPulsation");
			minScaleAtStart = s.Serialize<float>(minScaleAtStart, name: "minScaleAtStart");
			maxScaleAtStart = s.Serialize<float>(maxScaleAtStart, name: "maxScaleAtStart");
			minScaleAtEnd = s.Serialize<float>(minScaleAtEnd, name: "minScaleAtEnd");
			maxScaleAtEnd = s.Serialize<float>(maxScaleAtEnd, name: "maxScaleAtEnd");
			linkPulsation = s.Serialize<float>(linkPulsation, name: "linkPulsation");
			linkAmplitude = s.Serialize<float>(linkAmplitude, name: "linkAmplitude");
			playerFollowOffset = s.SerializeObject<Vec2d>(playerFollowOffset, name: "playerFollowOffset");
			speedBlend = s.Serialize<float>(speedBlend, name: "speedBlend");
			speedMin = s.Serialize<float>(speedMin, name: "speedMin");
			speedMax = s.Serialize<float>(speedMax, name: "speedMax");
			blendAtSpeedMin = s.Serialize<float>(blendAtSpeedMin, name: "blendAtSpeedMin");
			blendAtSpeedMax = s.Serialize<float>(blendAtSpeedMax, name: "blendAtSpeedMax");
			backToNormalInertia = s.Serialize<float>(backToNormalInertia, name: "backToNormalInertia");
			backToNormalBounciness = s.Serialize<float>(backToNormalBounciness, name: "backToNormalBounciness");
			backToNormalInitSpeed = s.Serialize<float>(backToNormalInitSpeed, name: "backToNormalInitSpeed");
			maxDistanceBeforeExploding = s.Serialize<float>(maxDistanceBeforeExploding, name: "maxDistanceBeforeExploding");
			radius = s.Serialize<float>(radius, name: "radius");
			minLinkThicknessFactor = s.Serialize<float>(minLinkThicknessFactor, name: "minLinkThicknessFactor");
			lenghtForMinThickness = s.Serialize<float>(lenghtForMinThickness, name: "lenghtForMinThickness");
			uvAnimTrans = s.SerializeObject<Vec2d>(uvAnimTrans, name: "uvAnimTrans");
			startAlphaLen = s.Serialize<float>(startAlphaLen, name: "startAlphaLen");
			endAlphaLen = s.Serialize<float>(endAlphaLen, name: "endAlphaLen");
			linkAlphaMultiplier = s.Serialize<float>(linkAlphaMultiplier, name: "linkAlphaMultiplier");
		}
		public override uint? ClassCRC => 0xA15FEC50;
	}
}

