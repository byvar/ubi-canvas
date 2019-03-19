using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class BasculePlatformComponent_Template : CSerializable {
		[Serialize("animPivotBone"          )] public StringID animPivotBone;
		[Serialize("animAddInput"           )] public StringID animAddInput;
		[Serialize("animMaxAngle"           )] public Angle animMaxAngle;
		[Serialize("stiff"                  )] public float stiff;
		[Serialize("damp"                   )] public float damp;
		[Serialize("weightToAngle"          )] public float weightToAngle;
		[Serialize("maxAngle"               )] public Angle maxAngle;
		[Serialize("weightMultiplier"       )] public float weightMultiplier;
		[Serialize("forceMultiplier"        )] public float forceMultiplier;
		[Serialize("crushMultiplier"        )] public float crushMultiplier;
		[Serialize("onStartRotatingFX"      )] public StringID onStartRotatingFX;
		[Serialize("rotatingClockwiseFX"    )] public StringID rotatingClockwiseFX;
		[Serialize("rotatingAntiClockwiseFX")] public StringID rotatingAntiClockwiseFX;
		[Serialize("onStopRotatingFX"       )] public StringID onStopRotatingFX;
		[Serialize("playStopFXDeltaAngle"   )] public Angle playStopFXDeltaAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animPivotBone));
			SerializeField(s, nameof(animAddInput));
			SerializeField(s, nameof(animMaxAngle));
			SerializeField(s, nameof(stiff));
			SerializeField(s, nameof(damp));
			SerializeField(s, nameof(weightToAngle));
			SerializeField(s, nameof(maxAngle));
			SerializeField(s, nameof(weightMultiplier));
			SerializeField(s, nameof(forceMultiplier));
			SerializeField(s, nameof(crushMultiplier));
			SerializeField(s, nameof(onStartRotatingFX));
			SerializeField(s, nameof(rotatingClockwiseFX));
			SerializeField(s, nameof(rotatingAntiClockwiseFX));
			SerializeField(s, nameof(onStopRotatingFX));
			SerializeField(s, nameof(playStopFXDeltaAngle));
		}
		public override uint? ClassCRC => 0xB16627BB;
	}
}

