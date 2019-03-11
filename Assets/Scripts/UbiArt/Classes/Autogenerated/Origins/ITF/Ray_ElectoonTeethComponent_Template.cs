using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ElectoonTeethComponent_Template : CSerializable {
		[Serialize("xFromRight"           )] public float xFromRight;
		[Serialize("yFromTop"             )] public float yFromTop;
		[Serialize("itemWidth"            )] public float itemWidth;
		[Serialize("itemHeight"           )] public float itemHeight;
		[Serialize("spacing"              )] public float spacing;
		[Serialize("fontName"             )] public Path fontName;
		[Serialize("atlasPath"            )] public Path atlasPath;
		[Serialize("electoonScorePos"     )] public Vector2 electoonScorePos;
		[Serialize("electoonScoreHeight"  )] public float electoonScoreHeight;
		[Serialize("toothScorePos"        )] public Vector2 toothScorePos;
		[Serialize("toothScoreHeight"     )] public float toothScoreHeight;
		[Serialize("scoreColor"           )] public Color scoreColor;
		[Serialize("pulseDuration"        )] public float pulseDuration;
		[Serialize("pulseAmplitude"       )] public float pulseAmplitude;
		[Serialize("fadeSpeed"            )] public float fadeSpeed;
		[Serialize("incrementSpeed"       )] public float incrementSpeed;
		[Serialize("movementCurveDistance")] public float movementCurveDistance;
		[Serialize("relativeNormalSize"   )] public float relativeNormalSize;
		[Serialize("nearestRelativeZ"     )] public float nearestRelativeZ;
		[Serialize("interIconDelay"       )] public float interIconDelay;
		[Serialize("flightDuration"       )] public float flightDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(xFromRight));
			SerializeField(s, nameof(yFromTop));
			SerializeField(s, nameof(itemWidth));
			SerializeField(s, nameof(itemHeight));
			SerializeField(s, nameof(spacing));
			SerializeField(s, nameof(fontName));
			SerializeField(s, nameof(atlasPath));
			SerializeField(s, nameof(electoonScorePos));
			SerializeField(s, nameof(electoonScoreHeight));
			SerializeField(s, nameof(toothScorePos));
			SerializeField(s, nameof(toothScoreHeight));
			SerializeField(s, nameof(scoreColor));
			SerializeField(s, nameof(pulseDuration));
			SerializeField(s, nameof(pulseAmplitude));
			SerializeField(s, nameof(fadeSpeed));
			SerializeField(s, nameof(incrementSpeed));
			SerializeField(s, nameof(movementCurveDistance));
			SerializeField(s, nameof(relativeNormalSize));
			SerializeField(s, nameof(nearestRelativeZ));
			SerializeField(s, nameof(interIconDelay));
			SerializeField(s, nameof(flightDuration));
		}
		public override uint? ClassCRC => 0x6857CCE9;
	}
}

