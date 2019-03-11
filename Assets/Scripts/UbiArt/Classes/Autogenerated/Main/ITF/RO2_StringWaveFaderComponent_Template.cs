using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_StringWaveFaderComponent_Template : ActorComponent_Template {
		[Serialize("minBounceSpeed"      )] public float minBounceSpeed;
		[Serialize("maxDownwardSpeed"    )] public float maxDownwardSpeed;
		[Serialize("maxUpwardSpeed"      )] public float maxUpwardSpeed;
		[Serialize("upwardAcceleration"  )] public float upwardAcceleration;
		[Serialize("downwardAcceleration")] public float downwardAcceleration;
		[Serialize("bounceFactor"        )] public float bounceFactor;
		[Serialize("thresholdPosition"   )] public float thresholdPosition;
		[Serialize("linkeeScaleForOff"   )] public float linkeeScaleForOff;
		[Serialize("linkeeScaleForOn"    )] public float linkeeScaleForOn;
		[Serialize("crushSpeed"          )] public float crushSpeed;
		[Serialize("bounceOnEndFX"       )] public StringID bounceOnEndFX;
		[Serialize("goDownwardFX"        )] public StringID goDownwardFX;
		[Serialize("minSpeedForSound"    )] public float minSpeedForSound;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minBounceSpeed));
			SerializeField(s, nameof(maxDownwardSpeed));
			SerializeField(s, nameof(maxUpwardSpeed));
			SerializeField(s, nameof(upwardAcceleration));
			SerializeField(s, nameof(downwardAcceleration));
			SerializeField(s, nameof(bounceFactor));
			SerializeField(s, nameof(thresholdPosition));
			SerializeField(s, nameof(linkeeScaleForOff));
			SerializeField(s, nameof(linkeeScaleForOn));
			SerializeField(s, nameof(crushSpeed));
			SerializeField(s, nameof(bounceOnEndFX));
			SerializeField(s, nameof(goDownwardFX));
			SerializeField(s, nameof(minSpeedForSound));
		}
		public override uint? ClassCRC => 0x7A6DD69D;
	}
}

