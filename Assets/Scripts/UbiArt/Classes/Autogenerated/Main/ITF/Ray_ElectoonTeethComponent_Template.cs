using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ElectoonTeethComponent_Template : CSerializable {
		public float xFromRight;
		public float yFromTop;
		public float itemWidth;
		public float itemHeight;
		public float spacing;
		public Path fontName;
		public Path atlasPath;
		public Vec2d electoonScorePos;
		public float electoonScoreHeight;
		public Vec2d toothScorePos;
		public float toothScoreHeight;
		public Color scoreColor;
		public float pulseDuration;
		public float pulseAmplitude;
		public float fadeSpeed;
		public float incrementSpeed;
		public float movementCurveDistance;
		public float relativeNormalSize;
		public float nearestRelativeZ;
		public float interIconDelay;
		public float flightDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			xFromRight = s.Serialize<float>(xFromRight, name: "xFromRight");
			yFromTop = s.Serialize<float>(yFromTop, name: "yFromTop");
			itemWidth = s.Serialize<float>(itemWidth, name: "itemWidth");
			itemHeight = s.Serialize<float>(itemHeight, name: "itemHeight");
			spacing = s.Serialize<float>(spacing, name: "spacing");
			fontName = s.SerializeObject<Path>(fontName, name: "fontName");
			atlasPath = s.SerializeObject<Path>(atlasPath, name: "atlasPath");
			electoonScorePos = s.SerializeObject<Vec2d>(electoonScorePos, name: "electoonScorePos");
			electoonScoreHeight = s.Serialize<float>(electoonScoreHeight, name: "electoonScoreHeight");
			toothScorePos = s.SerializeObject<Vec2d>(toothScorePos, name: "toothScorePos");
			toothScoreHeight = s.Serialize<float>(toothScoreHeight, name: "toothScoreHeight");
			scoreColor = s.SerializeObject<Color>(scoreColor, name: "scoreColor");
			pulseDuration = s.Serialize<float>(pulseDuration, name: "pulseDuration");
			pulseAmplitude = s.Serialize<float>(pulseAmplitude, name: "pulseAmplitude");
			fadeSpeed = s.Serialize<float>(fadeSpeed, name: "fadeSpeed");
			incrementSpeed = s.Serialize<float>(incrementSpeed, name: "incrementSpeed");
			movementCurveDistance = s.Serialize<float>(movementCurveDistance, name: "movementCurveDistance");
			relativeNormalSize = s.Serialize<float>(relativeNormalSize, name: "relativeNormalSize");
			nearestRelativeZ = s.Serialize<float>(nearestRelativeZ, name: "nearestRelativeZ");
			interIconDelay = s.Serialize<float>(interIconDelay, name: "interIconDelay");
			flightDuration = s.Serialize<float>(flightDuration, name: "flightDuration");
		}
		public override uint? ClassCRC => 0x6857CCE9;
	}
}

