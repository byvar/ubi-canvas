using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ScoreGuageComponent_Template : CSerializable {
		[Serialize("textureLums"          )] public Path textureLums;
		[Serialize("countLums"            )] public uint countLums;
		[Serialize("gaugeLumsLimits_X_Min")] public float gaugeLumsLimits_X_Min;
		[Serialize("gaugeLumsLimits_X_Max")] public float gaugeLumsLimits_X_Max;
		[Serialize("gaugeLumsLimits_Y_Min")] public float gaugeLumsLimits_Y_Min;
		[Serialize("gaugeLumsLimits_Y_Max")] public float gaugeLumsLimits_Y_Max;
		[Serialize("sizeLums"             )] public float sizeLums;
		[Serialize("maxSpeedLums"         )] public float maxSpeedLums;
		[Serialize("gaugeOffsetY"         )] public float gaugeOffsetY;
		[Serialize("arrivalAnim"          )] public StringID arrivalAnim;
		[Serialize("idleAnim"             )] public StringID idleAnim;
		[Serialize("guageSmooth"          )] public float guageSmooth;
		[Serialize("waitingTime"          )] public float waitingTime;
		[Serialize("checkMapForMrDark"    )] public StringID checkMapForMrDark;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(textureLums));
			SerializeField(s, nameof(countLums));
			SerializeField(s, nameof(gaugeLumsLimits_X_Min));
			SerializeField(s, nameof(gaugeLumsLimits_X_Max));
			SerializeField(s, nameof(gaugeLumsLimits_Y_Min));
			SerializeField(s, nameof(gaugeLumsLimits_Y_Max));
			SerializeField(s, nameof(sizeLums));
			SerializeField(s, nameof(maxSpeedLums));
			SerializeField(s, nameof(gaugeOffsetY));
			SerializeField(s, nameof(arrivalAnim));
			SerializeField(s, nameof(idleAnim));
			SerializeField(s, nameof(guageSmooth));
			SerializeField(s, nameof(waitingTime));
			SerializeField(s, nameof(checkMapForMrDark));
		}
		public override uint? ClassCRC => 0x22914144;
	}
}

