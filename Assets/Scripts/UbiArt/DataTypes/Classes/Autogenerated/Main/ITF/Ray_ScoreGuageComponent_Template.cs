using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ScoreGuageComponent_Template : ActorComponent_Template {
		public Path textureLums;
		public uint countLums;
		public float gaugeLumsLimits_X_Min;
		public float gaugeLumsLimits_X_Max;
		public float gaugeLumsLimits_Y_Min;
		public float gaugeLumsLimits_Y_Max;
		public float sizeLums;
		public float maxSpeedLums;
		public float gaugeOffsetY;
		public StringID arrivalAnim;
		public StringID idleAnim;
		public float guageSmooth;
		public float waitingTime;
		public StringID checkMapForMrDark;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			textureLums = s.SerializeObject<Path>(textureLums, name: "textureLums");
			countLums = s.Serialize<uint>(countLums, name: "countLums");
			gaugeLumsLimits_X_Min = s.Serialize<float>(gaugeLumsLimits_X_Min, name: "gaugeLumsLimits_X_Min");
			gaugeLumsLimits_X_Max = s.Serialize<float>(gaugeLumsLimits_X_Max, name: "gaugeLumsLimits_X_Max");
			gaugeLumsLimits_Y_Min = s.Serialize<float>(gaugeLumsLimits_Y_Min, name: "gaugeLumsLimits_Y_Min");
			gaugeLumsLimits_Y_Max = s.Serialize<float>(gaugeLumsLimits_Y_Max, name: "gaugeLumsLimits_Y_Max");
			sizeLums = s.Serialize<float>(sizeLums, name: "sizeLums");
			maxSpeedLums = s.Serialize<float>(maxSpeedLums, name: "maxSpeedLums");
			gaugeOffsetY = s.Serialize<float>(gaugeOffsetY, name: "gaugeOffsetY");
			arrivalAnim = s.SerializeObject<StringID>(arrivalAnim, name: "arrivalAnim");
			idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
			guageSmooth = s.Serialize<float>(guageSmooth, name: "guageSmooth");
			waitingTime = s.Serialize<float>(waitingTime, name: "waitingTime");
			checkMapForMrDark = s.SerializeObject<StringID>(checkMapForMrDark, name: "checkMapForMrDark");
		}
		public override uint? ClassCRC => 0x22914144;
	}
}

